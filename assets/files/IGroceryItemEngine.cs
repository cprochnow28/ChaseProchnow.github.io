using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLlama.Models;

namespace ListLlama.Engines
{
    public interface IGroceryItemEngine
    {
        IEnumerable<GroceryItem> GetGroceryItems();
        IEnumerable<GroceryItem> GetItemsOnList(int ListId);
        GroceryItem GetGroceryItem(int id);

        GroceryItem InsertGroceryItem(GroceryItem newGroceryitem);

        GroceryItem UpdateGroceryItem(int id, GroceryItem updated);

        GroceryItem DeleteGroceryItem(int id);
    }
}
