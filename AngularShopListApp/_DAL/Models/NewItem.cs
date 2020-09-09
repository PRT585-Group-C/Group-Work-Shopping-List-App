using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace GroupCWebAPI._DAL.Models
{
    public class NewItem
    {
        public int Id { get; set; }

   
        public string Name { get; set; }


        public string Barcode { get; set; }

        public DateTime createdDate { get; set; }


        public string Size { get; set; }


        public string Price { get; set; }


       // public Languages Languages { get; set; }


       // public int CategoryId { get; set; }

       // public  CategoryViewModel Category { get; set; }
        //  https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
