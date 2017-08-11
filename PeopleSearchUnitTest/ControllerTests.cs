using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PeopleSearch.Controllers;
using PeopleSearch.Models;

namespace PeopleSearchUnitTest
{
    [TestClass]
    public class ControllerTests
    {
        private readonly PersonContext _context;

        public PersonContext Context => _context;

        [TestMethod]
        public void HomeController_Index_Test()
        {
            // Arrange
            var controller = new HomeController(Context);

            // Act    
            IActionResult actionResult = controller.Index();

            // Assert
            Assert.IsNotNull(actionResult);
        }
    }
}
