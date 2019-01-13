using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GeneralOnlineShoping.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { set; get; }
        [Required]
        public double Price { set; get; }
        [DataType(DataType.MultilineText)]
        public string Description { set; get; }
        public string Category { set; get; }
    }
}