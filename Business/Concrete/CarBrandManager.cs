using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CarBrand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(CarBrand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<CarBrand>> GetAll()
        {
            return new SuccessDataResult<List<CarBrand>>(_brandDal.GetAll(),Messages.BrandListed);
            
        }

        public IDataResult<CarBrand> GetById(int brandId)
        {
            return new SuccessDataResult<CarBrand>(_brandDal.Get(b => b.Id == brandId));
        }

        public IResult Update(CarBrand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
