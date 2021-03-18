using Core.DataAccess.EntityFramework;
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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentcarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentcarContext context = new RentcarContext())
            {
                var result = from r in context.Rentals join c in context.Cars on r.CarId equals c.CarId join m in context.Customers on r.CustomerId equals m.CustomerId select new RentalDetailDto { RentId=r.RentId,CarId=r.CarId,CustomerId=m.CustomerId,CarName=c.CarName,CustomerName=m.CompanyName };
                return result.ToList();
            }
        }
    }
}
