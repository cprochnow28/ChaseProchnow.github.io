using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListLlama.Accessors;
using ListLlama.Models;

namespace ListLlama.Engines
{
    public class GroceryListEngine : IGroceryListEngine
    {
        private readonly IGroceryListAccessor _groceryListAccessor;

        public GroceryListEngine()
        {
            _groceryListAccessor = new GroceryListAccessor();
        }
        public IEnumerable<GroceryList> GetAllGroceryLists()
        {
            return _groceryListAccessor.GetAll();
        }
        public IEnumerable<GroceryList> GetGroceryLists()
        {
            return _groceryListAccessor.GetAll().ToList();
        }

        public GroceryList GetGroceryList(int id)
        {
            return _groceryListAccessor.Get(id);
        }

        public GroceryList InsertGroceryList(GroceryList newGroceryList)
        {
            _groceryListAccessor.Add(newGroceryList);
            return newGroceryList;
        }

        public GroceryList UpdateGroceryList(int id, GroceryList updated)
        {
            _groceryListAccessor.Edit(id, updated);
            return updated;
        }

        public GroceryList DeleteGroceryList(int id)
        {
            var groceryList = _groceryListAccessor.Get(id);
            if (groceryList != null)
            {
                _groceryListAccessor.Delete(groceryList.GroceryListId);
            }
            return groceryList;
        }
    }
}