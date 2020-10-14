using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GroupCWebAPI._BAL.Models;
using GroupCWebAPI._DAL.Models;
using GroupCWebAPI._DAL.Services;
using System;
using GroupCWebAPI.Data;

namespace GroupCWebAPI._DAL.Services
{
    public interface IDALService
    {
        List<NewItemBLLModel> FetchAllNewIems();
        void DeleteNewItem(long id);
        void UpdateNewItem(NewItemBLLModel model);
        void AddNewItem(NewItemBLLModel model);

        NewItemBLLModel findNewItem(long id);
        List<NewItemBLLModel> searchItems(string name);
    }

    public class DALServices : IDALService
    {
        private readonly ApplicationDbContext context;

        public DALServices(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public List<NewItemBLLModel> FetchAllNewItems()
        {
            var efModel = context.NewItem.ToList();
            var returnObject = new List<NewItemBLLModel>();

            foreach (var item in efModel)
            {
                returnObject.Add(new NewItemBLLModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    createdDate = item.createdDate,
                    Size = item.Size,
                    Price = item.Price,
                    Pic = item.Pic
                });
            }

            return returnObject;
        }



        public List<NewItemBLLModel> FetchAllNewIems()
        {
            var efModel = context.NewItem.ToList();
            var returnObject = new List<NewItemBLLModel>();

            foreach (var item in efModel)
            {
                returnObject.Add(new NewItemBLLModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    createdDate = item.createdDate,
                    Size = item.Size,
                    Price = item.Price,
                    Pic = item.Pic
                });
            }

            return returnObject;
        }

        public void DeleteNewItem(long id)
        {
            var item = context.NewItem
    .Where(p => p.Id == id).FirstOrDefault();
            if (item != null)
            {
                context.Entry(item).State = EntityState.Deleted;
                context.SaveChanges();
            }



        }

        public List<NewItemBLLModel> searchItems(string name)
        {

            var movies = from m in context.NewItem
                         select m;

            if (!String.IsNullOrEmpty(name))
            {
                movies = movies.Where(s => s.Name.Contains(name));
            }

            var returnObject = new List<NewItemBLLModel>();

            foreach (var item in movies)
            {
                returnObject.Add(new NewItemBLLModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    createdDate = item.createdDate,
                    Size = item.Size,
                    Price = item.Price,
                      Pic = item.Pic
                });
            }

            return returnObject;
        }

            public void UpdateNewItem(NewItemBLLModel model)
        {
            var item = context.NewItem
          .Where(p => p.Id == model.Id).FirstOrDefault();
            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(model);
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void AddNewItem(NewItemBLLModel model)
        {
            var item = new NewItem()
            {
                Id = model.Id,
                Name = model.Name,
                createdDate = model.createdDate,
                Size = model.Size,
                Price = model.Price,
                Pic = model.Pic
            };
            context.NewItem.Add(item);
            context.SaveChanges();
        }

        NewItemBLLModel IDALService.findNewItem(long id)
        {
            //var item = context.NewItem.FindAsync(id);
            var item = context.NewItem
              .Where(p => p.Id == id).FirstOrDefault();
          NewItemBLLModel returnObject = null  ;
            if (item != null)
            {
                returnObject = new NewItemBLLModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    createdDate = item.createdDate,
                    Size = item.Size,
                    Price = item.Price,
                    Pic=item.Pic
    };

            }


            return returnObject;
        }
    }
}
