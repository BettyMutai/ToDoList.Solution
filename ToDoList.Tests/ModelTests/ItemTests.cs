using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests.ModelTests
{
    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new("test");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Walk the dog.";
            Item newItem = new(description);
            //Act
            string result = newItem.Description;
            //Assert
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string desciption = "Walk the dog.";
            Item newItem = new(desciption);

            //Act
            string updateDescription = "Do the dishes.";
            newItem.Description = updateDescription;
            string result = newItem.Description;

            //Assert
            Assert.AreEqual(updateDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            //Arrange
            List<Item> newList = new() { };


            //Act
            List<Item> result = Item.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
