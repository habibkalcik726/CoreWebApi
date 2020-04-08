using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class HotelRoomInfoModel
    {

        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public float Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public string RoomType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
     

    }
}
