using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal
    {
        /*List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId = 1, ColorId = 1, DailyPrice =300000,ModelYear =2000,Description= "tekerlekli eski araba"},
                new Car{Id=2,BrandId = 2, ColorId = 2, DailyPrice =900000,ModelYear =2007,Description= "tekerlekli vasat araba"},
                new Car{Id=3,BrandId = 3, ColorId = 3, DailyPrice =1000000,ModelYear =2010,Description= "tekerlekli meh araba"},
                new Car{Id=4,BrandId = 4, ColorId = 4, DailyPrice =3000000,ModelYear =2019,Description= "tekerlekli iyi araba"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            _cars.Find(x => x.Id == id);
        }

        public List<Car> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }*/
    }
}
