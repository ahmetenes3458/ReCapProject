﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentcarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentcarContext context = new RentcarContext())
            {
                var result = from c in context.Cars join b in context.Brands on c.BrandId equals b.BrandId join r in context.Colors on c.ColorId equals r.ColorId select new CarDetailDto { BrandName=b.BrandName,CarName=c.CarName,ColorName=r.ColorName,DailyPrice=c.DailyPrice,Description=c.Description };
                return result.ToList();
            }
        }
    }
}
