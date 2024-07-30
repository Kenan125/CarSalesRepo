using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCarDetailsTest();
            Console.WriteLine("-------------");
            ColorTest();
            Console.WriteLine("-------------");
            BrandTest();




        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName +" "+ car.Model +" " + car.ColorName + " " + car.DailyPrice + " " + car.Description);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            var result = carColorManager.GetAll();
            foreach (var color in result.Data )
            {
                Console.WriteLine(color.ColorName);
                
            }
            Console.WriteLine(result.Message);
        }
        private static void BrandTest()
        {
            CarBrandManager brandManager = new CarBrandManager(new EfCarBrandDal());
            var result =  brandManager.GetAll();
            foreach (var category in result.Data)
            {
                Console.WriteLine(category.BrandName);
                
            }
            Console.WriteLine(result.Message);
        }
    }
}
