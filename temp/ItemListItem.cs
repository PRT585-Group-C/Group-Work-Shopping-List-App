using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupCWebAPI.ViewModels
{
    public class ItemListItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int ItemListId { get; set; }
        public ItemList ItemList { get; set; }
    }
}
