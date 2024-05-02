using System;

namespace Hotelier.WebUI.DTOS.BookingDTO
{
    public class ApprovedReservationDTO
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string Request { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
