using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using GroupCWebAPI._BAL.Models;
using GroupCWebAPI.Models;
using GroupCWebAPI._DAL.Services;
using System.Linq;
using System;

namespace GroupCWebAPI._BAL.Services
    {
    public interface InewItemService
    {
        NewItemBLLModel FetchById(long id);
        List<NewItemBLLModel> FetchAll();
        void Update(NewItemBLLModel model);
        void Add(NewItemBLLModel model);
        void Delete(long id);

    }

    public class NewItemService : InewItemService
    {

        private readonly IDALService _dataAccessService;

        public NewItemService(IDALService dataAccessService)
        {
            // _dataAccessService = new DataAccessService();
            _dataAccessService = dataAccessService;
        }


        NewItemBLLModel InewItemService.FetchById(long id)
        {
            var result = new NewItemBLLModel();
            //try
            //{
            //    result = _dataAccessService.f.FetchEmployee(id);

            //}
            //catch (Exception e)
            //{
            //    //
            //}

            return result;
        }

        List<NewItemBLLModel> InewItemService.FetchAll()
        {
            var result = new List<NewItemBLLModel>();
            try
            {
                result = _dataAccessService.FetchAllNewIems(); //.OrderBy(x => x.Sequence);
                result = result.Where(x => x.IsRetired == false).ToList();
            }
            catch (Exception e)
            {
                //result.Errors.Add(e.BuildExceptionMessage());
            }
            return result;
        }

        public void Update(NewItemBLLModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Add(NewItemBLLModel model)
        {
            _dataAccessService.AddNewItem(model);

        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

     
    }

}
