using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLlama.Models;

namespace ListLlama.Engines
{
    interface IGroceryListEngine
    {
        IEnumerable<GroceryList> GetGroceryLists();
        IEnumerable<GroceryList> GetAllGroceryLists();
        GroceryList GetGroceryList(int id);

        GroceryList InsertGroceryList(GroceryList newGroceryList);

        GroceryList UpdateGroceryList(int id, GroceryList updated);

        GroceryList DeleteGroceryList(int id);
    }
}
