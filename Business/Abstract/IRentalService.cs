﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<Rental> GetById(int rentId);
        IResult Add(Rental rental);
    }
}
