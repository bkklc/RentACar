using Business.Concretes;
using Business.Constants;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());

//CarAddTest(carManager);
//DeleteCarTest(carManager);
//CarUpdateTest(carManager);
//CarGetAllTest(carManager);
//GetCarsByBrandIdTest(carManager);
//GetCarsByColorId(carManager);
//GetCarsDetailsTest(carManager);


///////////////////////////////////////////////////////////////////

//ColorGetAllTest(colorManager);

///////////////////////////////////////////////////////////////////

//BrandGetAllTest(brandManager);


static void CarAddTest(CarManager carManager)
{
    Car car1 = new Car();
    car1.BrandId = 1003;
    car1.ColorId = 1;
    car1.CarName = "911 Turbo";
    car1.ModelYear = 2023;
    car1.DailyPrice = 10560;
    car1.Description = "Description";

    carManager.Add(car1);
}
static void DeleteCarTest(CarManager carManager)
{
    Console.WriteLine("--------------Deleted Cars----------------------");    

    foreach (var car in carManager.GetCarsByBrandId(2).Data)
    {
        Console.WriteLine(car.CarName);
        carManager.Delete(car);
    }

    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.CarName);
    }
}
static void CarUpdateTest(CarManager carManager)
{
    Car car1 = new Car();
    car1.Id = 1003;
    car1.BrandId = 2;
    car1.ColorId = 1;
    car1.ModelYear = 2023;
    car1.DailyPrice = 54870;
    car1.CarName = "S680";
    car1.Description = "2023 Model";
    carManager.Update(car1);
}
static void CarGetAllTest(CarManager carManager)
{
    Console.WriteLine("--------------Cars GetAll----------------------");


    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.CarName);
    }
}
static void GetCarsByBrandIdTest(CarManager carManager)
{
    Console.WriteLine("--------------GetCarsByBrandId == 2----------------------");

    foreach (var car in carManager.GetCarsByBrandId(2).Data)
    {
        Console.WriteLine(car.CarName);
    }
}
static void GetCarsByColorId(CarManager carManager)
{
    Console.WriteLine("--------------GetCarsByColorId == 1----------------------");


    foreach (var car in carManager.GetCarsByColorId(1).Data)
    {

        Console.WriteLine(car.CarName);
    }
}
static void GetCarsDetailsTest(CarManager carManager)
{
    Console.WriteLine("--------------GetCarDetails----------------------");

    foreach (var car in carManager.GetCarDetails().Data)
    {
        Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName);
    }
}

static void ColorGetAllTest(ColorManager colorManager)
{
    Console.WriteLine("--------------ColorGetAll----------------------");

    foreach (var color in colorManager.GetAll().Data)
    {
        Console.WriteLine(color.ColorName);
    }
}


static void BrandGetAllTest(BrandManager brandManager)
{
    Console.WriteLine("--------------GetAllBrand----------------------");

    foreach (var brand in brandManager.GetAll().Data)
    {
        Console.WriteLine(brand.BrandName);
    }
}
