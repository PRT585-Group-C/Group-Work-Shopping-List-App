using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GroupCWebAPI._BAL.Models
{
    public class NewItemBLLModel
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public string Barcode { get; set; }

        public DateTime createdDate { get; set; }


        public string Size { get; set; }


        public string Price { get; set; }
        public bool IsRetired { get; internal set; }
    }
}
