using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GymAssignment.Controllers;
using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GymAssignmentTests
{

    public class HomeTesting
    {

        //Test is to make sure that the web pages are correctly displayed and that the links work
        [Fact]
        public void IndexTest()
        {

            //Arrange
            HomeController controller = new HomeController(null);
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.NotNull(result);        }
        //Test is to make sure that the web pages are correctly displayed and that the links work
        [Fact]
        public void AboutTest()
        {

            //Arrange
            HomeController controller = new HomeController(null);
            //Act
            ViewResult result = controller.About() as ViewResult;
            //Assert
            Assert.NotNull(result);
        }


    }
}
