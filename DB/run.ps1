IF (!(Get-Module -Name sqlps))
{
    Write-Host 'Loading SQLPS Module' -ForegroundColor DarkYellow
    Push-Location
    Import-Module sqlps -DisableNameChecking
    Pop-Location
}
  
#Some vars
$strMsg = '{0}{1} =>' -f [Environment]::NewLine, "Path"

#Settings  
#Set-ExecutionPolicy -ExecutionPolicy Unrestricted
$ErrorActionPreference = "Inquire"
$server = "ERIK-PC\SQLEXPRESS"
$db = "Handyman"


#Path of scripts
$schema = "Schema-Model\dbo\Schema.sql"
$tables = "Schema-Model\dbo\Tables\"
$constraints = "Schema-Model\dbo\Constraints\Constraint.sql"
$indexes = "Schema-Model\dbo\Indexes\Indexes.sql"
$data = "Data\"

													
#Create function to run scripts
Function Run-Script {
	Param ($path)

    #Print the file name contains db objects
    Write-Host $strMsg $path -ForegroundColor DarkYellow

	$scripts = Get-ChildItem $path | Where-Object {$_.Extension -eq ".sql"} | Sort-Object -Property Name
	foreach ($s in $scripts)
	{
		Write-Host "Running: ["(get-date).ToString('T')"]" $s.Name -BackgroundColor DarkGreen -ForegroundColor White

		#execute script against database
		Invoke-Sqlcmd -ServerInstance $server -Database $db -InputFile $s.FullName -QueryTimeout 0
	}		
}


##########################################################
#run db creation script
Invoke-Sqlcmd -ServerInstance $server -InputFile $schema

#run table creation scripts
Run-Script $tables
Invoke-Sqlcmd -ServerInstance $server -Database $db -InputFile $constraints

##########################################################
#run data sequence scripts
Run-Script $data
##########################################################

#run indexes creation scripts
Invoke-Sqlcmd -ServerInstance $server -Database $db -InputFile $indexes

#end of batch

#For PowerShell Console
#Write-Host -NoNewLine 'Press any key to continue...';
#$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown");

#Works in PowerShell ISE
read-host “Press ENTER to continue...”