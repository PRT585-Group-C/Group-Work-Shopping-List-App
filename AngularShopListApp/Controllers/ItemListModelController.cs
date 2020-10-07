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

namespace GroupCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemListModelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemListModelController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        // GET: api/ItemsList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemList>>> GetItemLists()
        {
            return await _context.ItemLists.ToListAsync();
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemList>> GetItemLists(int id)
        {
            var ItemLists = await _context.ItemLists.FindAsync(id);

            if (ItemLists == null)
            {
                return NotFound();
            }

            return ItemLists;
        }

        // POST: api/
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemList>> PostItemList(ItemList itemlist)
        {
            _context.ItemLists.Add(itemlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemLists", new { id = itemlist.Id}, itemlist);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemList>> DeleteItems(int id)
        {
            var items = await _context.ItemLists.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }

            _context.ItemLists.Remove(items);
            await _context.SaveChangesAsync();

            return items;
        }

        private bool ItemsExists(int id)
        {
            return _context.ItemLists.Any(e => e.Id == id);
        }


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
