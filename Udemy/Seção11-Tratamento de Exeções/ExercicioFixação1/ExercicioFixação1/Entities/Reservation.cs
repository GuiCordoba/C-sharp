﻿using System;


namespace ExercicioFixação1.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { 
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public  int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " 
                + RoomNumber
                +", CheckIn: "
                +CheckIn.ToString("dd/MM/yyyy")
                +", checkout: "
                +CheckOut.ToString("dd/MM/yyyy")
                +", "
                +Duration()
                +" nights.";
        }
    }
}
