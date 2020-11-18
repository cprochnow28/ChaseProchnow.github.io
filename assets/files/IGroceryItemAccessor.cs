using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLlama.Models;

namespace ListLlama.Accessors
{
    interface IGroceryItemAccessor
    {
        void Dispose(bool disposing);

        GroceryItem Get(int groceryItemId);

        IEnumerable<GroceryItem> GetOnlyItemsForList(int listId);

        void Add(GroceryItem groceryItem);

        IEnumerable<GroceryItem> GetAll();

        void Edit(int groceryItemId, GroceryItem newGroceryItem);

        void Delete(int groceryItemId);
    }
}
