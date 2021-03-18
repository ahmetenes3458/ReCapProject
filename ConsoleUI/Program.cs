using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName+" / "+car.ColorName+" / "+car.CarName+" / "+car.DailyPrice);
            //    }
            //}
            RentalManager rental = new RentalManager(new EfRentalDal());
            var result1 = rental.GetRentalDetails();
            if (result1.Success == true)
            {
                foreach (var rent in result1.Data)
                {
                    Console.WriteLine(rent.CarId + " / " + rent.CustomerId + " / " + rent.RentId + " / " + rent.CarName+" / "+rent.CustomerName);
                }
            }
        }
    }
}
