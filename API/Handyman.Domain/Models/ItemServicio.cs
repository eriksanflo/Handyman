using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class ItemServicio
    {
        public int IdItem { get; set; }
        public string ImagenUrl { get; set; }

        public virtual Item IdItemNavigation { get; set; }
    }
}
