using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete 
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if ((int)car.Description.Length > 2 && (int)car.DailyPrice > 0)
            {
                _CarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araç bilgileri hatalı.");
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _CarDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        
    }
}
