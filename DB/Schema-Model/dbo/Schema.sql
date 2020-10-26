USE master 
GO  

SET NOCOUNT ON 
DECLARE @DBName varchar(50) = 'Handyman'
DECLARE @Spidstr varchar(8000) = ''
DECLARE @ConnKilled smallint = 0  

IF db_id(@DBName) < 4 
BEGIN 
	PRINT 'Connections to system databases cannot be killed' 
	RETURN 
END 

SELECT @Spidstr=coalesce(@Spidstr,',' )+'kill '+convert(varchar, spid)+ '; ' 
FROM master..sysprocesses WHERE dbid=db_id(@DBName) 
 
IF LEN(@Spidstr) > 0
BEGIN 
	EXEC(@Spidstr) 
	PRINT @Spidstr
	SELECT @ConnKilled = COUNT(1) 
	FROM master..sysprocesses WHERE dbid=db_id(@DBName) 
END

IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @DBName OR name = @DBName)))
BEGIN
	DROP DATABASE Handyman
END	
GO

/*CREACION DE LA BASE DE DATOS **************************************************************************************************/
/********************************************************************************************************************************/
BEGIN
DECLARE @Default_data_path VARCHAR (700);
DECLARE @Default_log_path VARCHAR (700);
DECLARE @sqlstring varchar(1024)

SET @Default_data_path = (SELECT
    CONVERT(VARCHAR(700), SERVERPROPERTY('INSTANCEDEFAULTDATAPATH'))
        + 'Handyman.mdf');

SET @Default_log_path = ( SELECT
    CONVERT(VARCHAR(700), SERVERPROPERTY('INSTANCEDEFAULTLOGPATH'))
        + 'Handyman_log.ldf')


SET @sqlstring = 'CREATE DATABASE [Handyman] 	
	CONTAINMENT = NONE
	ON PRIMARY 
	    ( NAME = N''Handyman'', FILENAME = '''+@Default_data_path+''' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB  )
	LOG ON 
	    ( NAME = N''Handyman_log'', FILENAME = '''+@Default_log_path+''' , SIZE = 10240KB , MAXSIZE = 512GB , FILEGROWTH = 10%)
	COLLATE SQL_Latin1_General_CP1_CI_AS'

EXEC(@sqlstring)

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
BEGIN
	EXEC [Handyman].[dbo].[sp_fulltext_database] @action = 'enable'
END

ALTER DATABASE [Handyman] SET ANSI_NULL_DEFAULT OFF 
ALTER DATABASE [Handyman] SET ANSI_NULLS OFF 
ALTER DATABASE [Handyman] SET ANSI_PADDING OFF 
ALTER DATABASE [Handyman] SET ANSI_WARNINGS OFF 
ALTER DATABASE [Handyman] SET ARITHABORT OFF 
ALTER DATABASE [Handyman] SET AUTO_CLOSE OFF 
ALTER DATABASE [Handyman] SET AUTO_CREATE_STATISTICS ON 
ALTER DATABASE [Handyman] SET AUTO_SHRINK OFF 
ALTER DATABASE [Handyman] SET AUTO_UPDATE_STATISTICS ON 
ALTER DATABASE [Handyman] SET CURSOR_CLOSE_ON_COMMIT OFF 
ALTER DATABASE [Handyman] SET CURSOR_DEFAULT  GLOBAL 
ALTER DATABASE [Handyman] SET CONCAT_NULL_YIELDS_NULL OFF 
ALTER DATABASE [Handyman] SET NUMERIC_ROUNDABORT OFF 
ALTER DATABASE [Handyman] SET QUOTED_IDENTIFIER OFF 
ALTER DATABASE [Handyman] SET RECURSIVE_TRIGGERS OFF 
ALTER DATABASE [Handyman] SET  DISABLE_BROKER 
ALTER DATABASE [Handyman] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
ALTER DATABASE [Handyman] SET DATE_CORRELATION_OPTIMIZATION OFF 
ALTER DATABASE [Handyman] SET TRUSTWORTHY OFF 
ALTER DATABASE [Handyman] SET ALLOW_SNAPSHOT_ISOLATION OFF 
ALTER DATABASE [Handyman] SET PARAMETERIZATION SIMPLE 
ALTER DATABASE [Handyman] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [Handyman] SET RECOVERY SIMPLE
ALTER DATABASE [Handyman] SET  MULTI_USER 
ALTER DATABASE [Handyman] SET PAGE_VERIFY CHECKSUM  
ALTER DATABASE [Handyman] SET DB_CHAINING OFF 
ALTER DATABASE [Handyman] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

EXEC sys.sp_db_vardecimal_storage_format N'Handyman', N'ON'

END

GO

