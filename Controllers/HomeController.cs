
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Logging;//using Microsoft.Extensions.Logging;
using NLog;
//using Microsoft.Extensions.Logging;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // WebApiCoreContext context = new WebApiCoreContext();
        //DataBaseContext cfcontex = new DataBaseContext();

        private ILogger<Logger> _logger;// = LogManager.GetCurrentClassLogger();

        //private  NLog.Logger _logger; // readonlye bişey atayamazsın kanka.dur deniyim. olmuyor kanka

        public HomeController(ILogger<Logger> logger)
        {
            _logger = logger;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<HotelRoomInfo> GetRoomInfoList()
        {
            //HotelRoomInfo hri = new HotelRoomInfo();

            
            _logger.LogInformation("Get Room InfoList");
            _logger.LogDebug("Get Room InfoList Debug");


            HotelRoomInfo hotelInfoRoom = new HotelRoomInfo();
            hotelInfoRoom.HotelName = "Habib Oteller Zinciri";
            hotelInfoRoom.Price = 50000;
            hotelInfoRoom.RoomType = "Geniş";
            hotelInfoRoom.StartDate = DateTime.Now.AddDays(-20);
            hotelInfoRoom.TimeStamp = DateTime.Now;
            hotelInfoRoom.EndDate = hotelInfoRoom.StartDate.AddDays(25);

            //_context.HotelRoomInfo.Add(hotelInfoRoom);
            //_context.SaveChanges();
            return null;/// _context.HotelRoomInfo.ToList();
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost]
        public HotelRoomInfo SaveRoomInfo(HotelRoomInfo info)
        {
            HotelRoomInfo hotelInfoRoom = new HotelRoomInfo();
            //hotelInfoRoom.Hotelname = info.HotelName;
            //hotelInfoRoom.Price = info.Price;
            //hotelInfoRoom.Roomtype = info.HotelName;
            //hotelInfoRoom.Startdate = info.StartDate;
            //hotelInfoRoom.Timestamp = info.TimeStamp;
            //hotelInfoRoom.Enddate = info.EndDate;

            //_context.HotelRoomInfo.Add(hotelInfoRoom);
            //_context.SaveChanges();


            return hotelInfoRoom;
        }

    }
}