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
    public class CarColorManager : ICarColorService
    {
        ICarColor _carColor;

        public CarColorManager(ICarColor carColor)
        {
            _carColor = carColor;
        }

        public IResult Add(CarColor color)
        {
            _carColor.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(CarColor color)
        {
            _carColor.Delete(color);
            return new ErrorResult(Messages.ColorDeleted);
        }

        public IDataResult<List<CarColor>> GetAll()
        {
            return new SuccessDataResult<List<CarColor>>(_carColor.GetAll(),Messages.ColorListed);

        }

        public IDataResult<CarColor> GetColorById(int colorId)
        {
            return new SuccessDataResult<CarColor>(_carColor.Get(c => c.Id == colorId));
        }

        public IResult Update(CarColor color)
        {
            _carColor.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
