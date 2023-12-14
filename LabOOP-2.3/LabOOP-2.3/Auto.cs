using System;

namespace ParkingManagement
{
    public class Auto : INameAndCopy
    {
        public int RegistrationNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime ParkingDate { get; set; }

        public Auto(int registrationNumber, string ownerName, DateTime parkingDate)
        {
            RegistrationNumber = registrationNumber;
            OwnerName = ownerName;
            ParkingDate = parkingDate;
        }

        public Auto()
        {
            RegistrationNumber = 0;
            OwnerName = "";
            ParkingDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Registration Number: {RegistrationNumber}, Owner Name: {OwnerName}, Parking Date: {ParkingDate}";
        }

        public object DeepCopy()
        {
            Auto copiedAuto = new Auto
            {
                RegistrationNumber = this.RegistrationNumber,
                OwnerName = this.OwnerName,
                ParkingDate = this.ParkingDate
            };
            return copiedAuto;
        }

        public string Name { get; set; }
    }
}
