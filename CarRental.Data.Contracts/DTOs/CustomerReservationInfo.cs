﻿using CarRental.Business.Entities;

namespace CarRental.Data.Contracts.DTOs
{
    public class CustomerReservationInfo
    {
        public Account Customer { get; set; }
        public Reservation Reservation { get; set; }
        public Car Car { get; set; }
    }
}