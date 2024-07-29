using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+ " " + car.ColorName + " "+ car.DailyPrice + " "+ car.Description);
            }
            Console.WriteLine("-------------");
            ColorTest();
            



        }

        private static void ColorTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            foreach (var color in carColorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }
}
