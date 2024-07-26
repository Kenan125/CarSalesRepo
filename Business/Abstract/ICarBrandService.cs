using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarBrandService
    {
        List<CarBrand> GetAll();
        CarBrand GetById(int brandId);
        void Add(CarBrand brand);
        void Update(CarBrand brand);
        void Delete(CarBrand brand);
    }
}
