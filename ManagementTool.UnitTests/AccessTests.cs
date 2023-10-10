using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ManagementTool.UnitTests
{
    using ManagementTool.Helpers;
    [TestClass]
    public class AccessTests
    {
        [TestMethod]
        public void CanBeEditedBy_Admin_True()
        {
            // Arrange
            var accessHelper = new AccessHelper();

            // Act
            accessHelper.
                AccessHelper.CanBeEditedBy()
            // Asserts
        }
    }
}
