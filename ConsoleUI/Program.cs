using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails())
            {
                Console.WriteLine(car.DailyPrice );
            }
            Console.WriteLine("-------------");
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            foreach (var color in carColorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("---------------------------");

        }
    }
}
