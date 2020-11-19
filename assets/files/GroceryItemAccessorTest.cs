using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListLlama.Accessors;
using ListLlama.Models;

namespace LlamaTests.UnitTests.AccessorTests
{
    [TestClass]
    public class GroceryItemAccessorTest
    {
        GroceryItemAccessor groceryItemsAccessor = new GroceryItemAccessor();

        [TestMethod]
        public void GetGroceryItemTest()
        {
            GroceryItem expected = new GroceryItem
            {
                GroceryListId = 2,
                Title = "Takis",
                Quantity = 1,
                GroceryItemId = 3,
                IsChecked = false
            };

            var actual = groceryItemsAccessor.Get(3);

            Assert.AreEqual(actual.Title, expected.Title);
            Assert.AreEqual(actual.GroceryListId, expected.GroceryListId);
            Assert.AreEqual(actual.Quantity, expected.Quantity);
            Assert.AreEqual(actual.IsChecked, expected.IsChecked);
            Assert.AreEqual(actual.GroceryItemId, expected.GroceryItemId);
        }
    }
}
