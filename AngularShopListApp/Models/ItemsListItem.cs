using GroupCWebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupCWebAPI.ViewModels
{
    public class ItemsListItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int ItemsListId { get; set; }
        public ItemsList ItemsList { get; set; }
    }
}
