using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoreWebApi.Mapper;
using CoreWebApi.Models;
using CoreWebApi.Models.DTO.Manager;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;

namespace CoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        IMapper _mapper;
            //private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        Logger _logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();


        private readonly DataBaseContext _context;
        public HotelController(DataBaseContext context, IMapper mapper)
        {
            //_logger = logger;
            _context = context;
            _mapper = mapper;
        }



        [HttpGet("GetInfoList")]
        //[OutputCache(Duration = 10, VaryByParam = "none")]
        public HotelRoomInfo GetRoomInfo(int hotelid)
        {

            var veri = _context.HotelRoomInfo.ToList();
            var retvalue = _context.HotelRoomInfo.Where(x => x.HotelID == hotelid).ToList();
            if (retvalue.Count > 0)
            {
                _logger.Info("Got Successfully!");
                _logger.Error("Something happened.");

                return retvalue.FirstOrDefault();
            }
            return null;
        
        }
        //[ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost("PostInfoList")]
        public HotelRoomInfoModel SaveRoomInfo([FromBody] HotelRoomInfoModel info)
        {
            try
            {
    
                HotelRoomInfo hri = _mapper.Map<HotelRoomInfoModel, HotelRoomInfo>(info);
        
                _context.HotelRoomInfo.Add(hri);
                _context.SaveChanges();

                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
