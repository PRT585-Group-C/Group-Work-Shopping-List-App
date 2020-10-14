using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GroupCWebAPI._BAL.Models;
using GroupCWebAPI._BAL.Services;
using GroupCWebAPI.ViewModels;
using System.Media;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewItemsController : ControllerBase
    {
        
        private readonly InewItemService _NewItemService;

        private readonly ILogger<NewItemsController> _logger;
        //private readonly IEmployeeService _employeeService;
        public NewItemsController(ILogger<NewItemsController> logger, InewItemService newItemService)
        {
            _logger = logger;
            _NewItemService = newItemService;
        }

        // GET: api/NewItems
        [HttpGet]
       // public  Task<ActionResult<IEnumerable<NewItemViewModel>>> GetTodoItems()
         public ActionResult<IEnumerable<NewItemViewModel>> GetNewItems()

        {

            var newIntemBModels = _NewItemService.FetchAll();
          


            var vmList = new List<NewItemViewModel>();
            foreach (var item in newIntemBModels)
            {
                var vmNewItem = new NewItemViewModel();


                vmNewItem.Id = item.Id;
                vmNewItem.Name = item.Name.ToUpper();
                vmNewItem.createdDate = item.createdDate; //.ToString();
                vmNewItem.Size = item.Size;
                vmNewItem.Price = item.Price;
                vmNewItem.Pic = item.Pic;
                Console.WriteLine(item.Pic);
                /*
                if (item.Salary > 5)
                {
                    vmEmployee.SalaryColor = "green";
                }
                else
                {
                    vmEmployee.SalaryColor = "red";
                }
                */
                vmList.Add(vmNewItem);
            }
            

            return Ok(vmList);
    
        }



        // GET: api/NewItems/"test"
        [HttpGet("search/{name}")]
        // public  Task<ActionResult<IEnumerable<NewItemViewModel>>> GetTodoItems()
        public ActionResult<IEnumerable<NewItemViewModel>> SearchItems( string name)

        {

             var newIntemBModels = _NewItemService.searchItems(name);

         
            var vmList = new List<NewItemViewModel>();
            foreach (var item in newIntemBModels)
            {
                var vmNewItem = new NewItemViewModel();


                vmNewItem.Id = item.Id;
                vmNewItem.Name = item.Name.ToUpper();
                vmNewItem.createdDate = item.createdDate; //.ToString();
                vmNewItem.Size = item.Size;
                vmNewItem.Price = item.Price;
                vmNewItem.Pic = item.Pic;
                /*
                if (item.Salary > 5)
                {
                    vmEmployee.SalaryColor = "green";
                }
                else
                {
                    vmEmployee.SalaryColor = "red";
                }
                */
                vmList.Add(vmNewItem);
            }


            return Ok(vmList);

        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
       //public Task ActionResult<IEnumerable<NewItemViewModel>> GetNewItem(int id)
            public ActionResult<IEnumerable<NewItemViewModel>> GetNewItem(int id)
        {
          // var todoItem = await _context.TodoItems.FindAsync(id);
            var todoItem = _NewItemService.FetchById(id);


            if (todoItem == null)
           {
               return NotFound();
           }

            var vmNewItem = new NewItemViewModel();


            vmNewItem.Id = todoItem.Id;
            vmNewItem.Name = todoItem.Name.ToUpper();
            vmNewItem.createdDate = todoItem.createdDate; //.ToString();
            vmNewItem.Size = todoItem.Size;
            vmNewItem.Price = todoItem.Price;
            vmNewItem.Pic = todoItem.Pic;

            var vmList = new List<NewItemViewModel>();
            vmList.Add(vmNewItem);
            return vmList;
       }
         
        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]

        public ActionResult PutTodoItem(int id, NewItemViewModel newItem)
        //public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
   
      
           if (id != newItem.Id)
           {
                return BadRequest();
            }
            /*
             try
              {
                  await _context.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!TodoItemExists(id))
                  {
                      return NotFound();
                  }
                  else
                  {
                      throw;
                  }
              }*/
            var newIntemBModels = new NewItemBLLModel();
            newIntemBModels.Name = newItem.Name.ToUpper();
            //newIntemBModels.createdDate = newItem.createdDate; //.ToString();
            newIntemBModels.Id = newItem.Id;
            newIntemBModels.Size = newItem.Size;
            newIntemBModels.Price = newItem.Price;
            newIntemBModels.Pic = newItem.Pic;
            _NewItemService.Update(newIntemBModels);

            return Ok(newIntemBModels);
        }



        // POST: api/NewItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult PostTodoItem(NewItemViewModel newItem)

        //public Task<ActionResult<NewItemViewModel>> PostTodoItem(NewItemViewModel newItem)
        {
            var newIntemBModels = new NewItemBLLModel();
            newIntemBModels.Name = newItem.Name.ToUpper();
            newIntemBModels.createdDate = newItem.createdDate; //.ToString();
            newIntemBModels.Size = newItem.Size;
            newIntemBModels.Price = newItem.Price;
            newIntemBModels.Pic = newItem.Pic;
            _NewItemService.Add(newIntemBModels);

            return Ok(newIntemBModels);
            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        //  public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        public ActionResult DeleteTodoItem(int id)
        {
            /*
         var todoItem = await _context.TodoItems.FindAsync(id);
         if (todoItem == null)
         {
             return NotFound();
         }
            */

            _NewItemService.Delete(id);

            return Ok(id);
        }
       /*
     private bool TodoItemExists(long id)
     {
         return _context.TodoItems.Any(e => e.Id == id);
     }
        */
     
    }
}
