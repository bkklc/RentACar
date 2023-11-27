using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

CarManager carManager = new CarManager(new EfCarDal()) ;

//Car car1 = new Car() ;
//car1.BrandId = 2;
//car1.ColorId = 1;
//car1.CarName = "Bmw";
//car1.ModelYear = 2023;
//car1.DailyPrice = 10560;
//car1.Description = "Description";

//carManager.Add(car1);




foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarName);    
}
Console.WriteLine("--------------GetCarsByBrandId == 2----------------------");

foreach (var car in carManager.GetCarsByBrandId(2))
{
    Console.WriteLine(car.CarName);
}

Console.WriteLine("--------------GetCarsByColorId == 1----------------------");


foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.CarName);
}

