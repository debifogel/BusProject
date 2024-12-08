//using Microsoft.AspNetCore.Mvc;
//using Project__winter_2025.Controllers;
//using Project__winter_2025.data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace stationTest
//{
//    public class StationControllerTest
//    {
//        [Fact]
//        public void GetById_ReturnsNotFound()
//        {
//            //Arranges
//            var id = -1;

//            //Act
//            var controller = new StationController(new FakeDataContext());
//            var result = controller.Get(id);

//            //Assert
//            Assert.IsType<NotFoundResult>(result);
//        }
//        [Fact]
//        public void GetById_ReturnsOk()
//        {
//            //Arranges
//            var id = 1;

//            //Act
//            var controller = new StationController(new FakeDataContext());
//            var result = controller.Get(id);

//            //Assert
//            Assert.IsType<OkObjectResult>(result);
//        }
//    }
//}
