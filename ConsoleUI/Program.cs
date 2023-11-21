
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal()) ;

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Name);    
}

