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
    public class CarBrandManager : ICarBrandService
    {
        ICarBrand _brandDal;

        public CarBrandManager(ICarBrand brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(CarBrand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(CarBrand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<CarBrand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public CarBrand GetById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }

        public void Update(CarBrand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
