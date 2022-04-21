﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using ToDoList.Models;

namespace ToDoList.Tests.ModelTests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item("test");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            //Act
            string result = newItem.Description;
            //Assert
            Assert.AreEqual(description, result);
        }
    }
}
