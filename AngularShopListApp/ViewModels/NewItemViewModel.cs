using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCWebAPI.ViewModels
{
    public class NewItemViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Barcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime createdDate { get; set; }

        //[EmailAddress]
       // [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]

        public string Size { get; set; }

        [Required]
        public string Price { get; set; }


        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public  CategoryViewModel Category { get; set; }
        //  dddd https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
