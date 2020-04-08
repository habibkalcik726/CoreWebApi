using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    [Table("HotelRoomInfo")]
    public class HotelRoomInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public float Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public string RoomType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //hotelName, hotelId, price, timeStamp, roomType, startDate, endDate
    }
}
