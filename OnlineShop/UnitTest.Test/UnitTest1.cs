using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Controllers;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeMethod()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public async Task BrandMethod()
        {
            // Arrange
            BrandsController controller = new BrandsController();

            // Act
            Task result = controller.GetBrand() as Task;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CategoriesMethod()
        {
            // Arrange
            CategoriesController controller = new CategoriesController();

            // Act
            Task result = controller.Index() as Task;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ItemsMethod()
        {
            // Arrange
            ItemsController controller = new ItemsController();

            // Act
            Task result = controller.Index() as Task;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void RolesMethod()
        {
            // Arrange
            RolesController controller = new RolesController();

            // Act
            Task result = controller.Index() as Task;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void UsersMethod()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            Task result = controller.Index() as Task;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
