using GroupCWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupCWebAPI.Models
{
    public class ItemsList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<ItemsListItem> ItemsListItem { get; set; }
    }
}
