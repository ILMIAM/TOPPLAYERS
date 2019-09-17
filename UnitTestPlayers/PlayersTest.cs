using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPPLAYERS.Controllers;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestPlayers
{
    [TestClass]
    public class PlayersTest
    {
        [TestMethod]
        public void  ShouldReturnAllPlayers()
        {
            var controller = new PalyerController();
            var result = controller.Players() ;
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void ShouldReturnCorrectPlayer()
        {
            var controller = new PalyerController();
            IActionResult result = controller.GetById(17);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }

        [TestMethod]
        public void ShouldReturnDletePlayer()
        {
            var controller = new PalyerController();
            IActionResult actionResult = controller.Delete(17);
            Assert.IsNotNull(actionResult);
        }

        [TestMethod]
        public void ShouldReturnNotFountDletePlayer()
        {
            var controller = new PalyerController();
            IActionResult actionResult = controller.Delete(170);
          
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
           
        }
    }
}
