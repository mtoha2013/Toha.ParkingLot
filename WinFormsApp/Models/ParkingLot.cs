using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsApp.Models
{
    public partial class ParkingLot
    {
        public int Slot { get; set; }
        public string PlatNo { get; set; }
        public string MotorType { get; set; }
        public string RegistrationNoColour { get; set; }
        public DateTime? CheckInTime { get; set; }
    }
}
