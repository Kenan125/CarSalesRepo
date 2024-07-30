using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarSaleContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarSaleContext context = new CarSaleContext()) 
            {
                var result = from c in context.Cars
                             join p in context.Colors on c.ColorId equals p.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new CarDetailsDto
                             {
                                 
                                 BrandName = b.BrandName,
                                 ColorName = p.ColorName,
                                 Model = c.Model,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };

                return result.ToList();
            }
        }

        
    }
}
