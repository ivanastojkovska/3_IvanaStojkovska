using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_IvanaStojkovska.Models
{
    public class Link
    {
        [Key]
        public int ID { get; set; }
        [AllowHtml]
        [Display(Name = "Please input your link")]
        [DataType(DataType.Url)]
        public string LinkUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}