using System;

namespace Hw_3_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            Console.WriteLine("Your Name:");
            string PersonName = Console.ReadLine();

            Console.WriteLine("Your SurName:");
            string PersonSurName = Console.ReadLine();

            Console.WriteLine("Enter date of birth by dd/mm/yyyy:");
            Console.WriteLine("Enter day:");
            int PersonDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Month:");
            int PersonMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Year:");
            int PersonYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Hobby:");
            string PersonHobby = Console.ReadLine();

            Console.WriteLine("Your Sex (Male or Female):");
            string PersonSex = Console.ReadLine();

            person.Name = PersonName;
            person.SurName = PersonSurName;
            person.Day = PersonDay;
            person.Month = PersonMonth;
            person.Year = PersonYear;
            person.Hobby = PersonHobby;
            person.Sex = PersonSex;

            string PersonGreating = person.PersonShowGreating();

            Console.WriteLine(PersonGreating);

            //==========================================================


            Product product = new Product();

            Console.WriteLine("Enter Product Weight: ");
            double ProductWeightNew = double.Parse(Console.ReadLine());

            product.ProductWeight = ProductWeightNew;


            string ProductData = product.ProductShowData();
            Console.WriteLine(ProductData);

            //==========================================================

            Car car = new Car();

            Console.WriteLine("Enter Car Make: ");
            string CarMakeNew = Console.ReadLine();

            Console.WriteLine("Enter Car License Plate: ");
            string CarPlateNew = Console.ReadLine();

            Console.WriteLine("Enter Car Speed: ");
            double CarSpeedNew = double.Parse(Console.ReadLine());

            car.CarMake = CarMakeNew;
            car.CarPlate = CarPlateNew;
            car.CarSpeed = CarSpeedNew;

            string CarHorn = car.GetCarHorn();

            Console.WriteLine("Car Data: " + CarMakeNew + " " + CarPlateNew + " " + CarSpeedNew);
            Console.WriteLine(CarHorn);


            //==========================================================

            Phone phone = new Phone();

            Console.WriteLine("Enter Phone Manufacturer: ");
            string phoneManufacturer = Console.ReadLine();

            Console.WriteLine("Enter Phone Model: ");
            string phoneModel = Console.ReadLine();

            Console.WriteLine("Enter Phone Height: ");
            double phoneHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Width: ");
            double phoneWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Depth: ");
            Double phoneDepth = double.Parse(Console.ReadLine());

            phone.Manufacturer = phoneManufacturer;
            phone.Model = phoneModel;
            phone.Height = phoneHeight;
            phone.Width = phoneWidth;
            phone.Depth = phoneDepth;

            string PhoneData = phone.PhoneShowData();
            Console.WriteLine(PhoneData);




        }
    }
}
