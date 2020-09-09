using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCWebAPI.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
