using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests.ModelTests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void CategoryConstructor_CreatesInstanceOfCategory_Category()
        {
            Category newCategory = new Category("test category");
            Assert.AreEqual(typeof(Category), newCategory.GetType());
        }
    }
}
