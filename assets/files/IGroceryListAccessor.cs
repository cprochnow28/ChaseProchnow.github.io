using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLlama.Models;

namespace ListLlama.Accessors
{
    interface IGroceryListAccessor
    {
    void Dispose(bool disposing);
    
    GroceryList Get(int groceryListId);

    void Add(GroceryList groceryList);

    IEnumerable<GroceryList> GetAll();

    void Edit(int groceryListId, GroceryList newGroceryList);

    void Delete(int groceryListId);
    }
}
