using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GeneralOnlineShoping.Models
{
    public class UserAccount
    {
        private string Id { get; }
        public string Name { set; get; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Mail { set; get; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { set; get; }
    }
}