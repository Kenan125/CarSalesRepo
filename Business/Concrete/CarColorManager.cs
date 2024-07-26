using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarColorManager : ICarColorService
    {
        ICarColor _carColor;

        public CarColorManager(ICarColor carColor)
        {
            _carColor = carColor;
        }

        public void Add(CarColor color)
        {
            _carColor.Add(color);
        }

        public void Delete(CarColor color)
        {
            _carColor.Delete(color);
        }

        public List<CarColor> GetAll()
        {
            return _carColor.GetAll();
        }

        public CarColor GetColorById(int colorId)
        {
            return _carColor.Get(c => c.Id == colorId);
        }

        public void Update(CarColor color)
        {
            _carColor.Update(color);
        }
    }
}
