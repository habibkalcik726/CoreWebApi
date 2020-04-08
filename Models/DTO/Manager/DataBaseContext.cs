using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models.DTO.Manager
{
    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {


        public DataBaseContext(DbContextOptions options)
           : base(options)
        {

        }
        //public DatabaseContext()
        //{
        //    Database.SetInitializer<DatabaseContext>(new CreateDb());
        //}

        public Microsoft.EntityFrameworkCore.DbSet<HotelRoomInfo> HotelRoomInfo { set; get; }


    }
    //public class CreateDb : CreateDatabaseIfNotExists<DatabaseContext>
    //{

    //}
}
