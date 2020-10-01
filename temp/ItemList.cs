using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCWebAPI.ViewModels
{
    public class ItemList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime createdDate { get; set; }

        public string createdUser { get; set; }

        public List<ItemListItem> ItemListItem { get; set; }


        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public  CategoryViewModel Category { get; set; }
        //  dddd https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
