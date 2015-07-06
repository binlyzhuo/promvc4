using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMvc4.Models
{
    public class Reservation
    {
        public int ReservationId { set; get; }
        public string ClientName { set; get; }
        public string Location { set; get; }
    }

    public interface IReservationRepository
    {

    }

    public class ReservationRepository:IReservationRepository
    {

    }


}