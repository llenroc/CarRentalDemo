﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Business.Entities;
using Core.Common.Contracts;

namespace CarRental.Data.Contracts.Repository_Interfaces
{
    public interface ICarRepository : IDataRepository<Car>
    {
    }
}
