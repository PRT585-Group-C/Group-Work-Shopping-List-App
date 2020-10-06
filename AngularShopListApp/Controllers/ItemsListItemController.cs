using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GroupCWebAPI.ViewModels;
using GroupCWebAPI;
using AngularShopListApp.Data;
using GroupCWebAPI.Data;
using GroupCWebAPI.Models;
using Newtonsoft.Json;

namespace GroupCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsListItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemsListItemController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

      

        // POST: api/
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemsListItem>> PostItemsListItem(ItemsListItem ItemsListItemObj)
        {
            // _context.ItemsLists.Add(itemlist);
            // await _context.SaveChangesAsync();

            //return CreatedAtAction("GetItemsLists", new { id = itemlist.Id}, itemlist);
            
            try
            {
                ItemsList itemsList = await _context.ItemsLists
                    //.AsNoTracking()
                    //.Include(c => c.ItemsListItem).ThenInclude(cs => cs.Item)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.Id == ItemsListItemObj.ItemsListId);
        if (itemsList == null)
                {
                    return NotFound("itemsList not found!");
                }
                Item item = await _context.Items
                    .AsNoTracking()
                    .FirstOrDefaultAsync(s => s.Id == ItemsListItemObj.ItemId);
                if (item == null)
                {
                    return NotFound("item not found!");
                }
                /* ItemsListItem ItemsListItem2 = new ItemsListItem
                 {
                     ItemsList = itemsList,
                     ItemId= ItemsListItemObj.ItemId,
                     Item = item,
                     ItemsListId= ItemsListItemObj.ItemsListId
                 };
                */
             

               
                await _context.ItemsListItems.AddAsync(ItemsListItemObj);
                await _context.SaveChangesAsync();

                ItemsListItemObj.Item = item;
                ItemsListItemObj.ItemsList = itemsList;

                return Ok(ItemsListItemObj);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
           

        }


        private bool ItemsExists(int id)
        {
            return _context.ItemsLists.Any(e => e.Id == id);
        }

        /*
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemsList>> DeletesItems(int id)
        {
            var items = await _context.ItemsLists.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }

            _context.ItemsLists.Remove(items);
            await _context.SaveChangesAsync();

            return items;
        }
        // GET: api/ItemsList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsList>>> GetItemsLists()
        {
            return await _context.ItemsLists.ToListAsync();
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsList>> GetItemsLists(int id)
        {
            var ItemLists = await _context.ItemsLists.FindAsync(id);

            if (ItemLists == null)
            {
                return NotFound();
            }

            return ItemLists;
        }
        */
     

    }
}






/*namespace webApiPeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly Context _context;

        public ItemController(Context context)
        {
            _context = context;
        }


        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItems(int id, Item items)
        {
            if (id != items.Id)
            {
                return BadRequest();
            }

            _context.Entry(items).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Item>> DeleteItems(int id)
        {
            var items = await _context.Items.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }

            _context.Items.Remove(items);
            await _context.SaveChangesAsync();

            return items;
        }

        private bool ItemsExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}*/
