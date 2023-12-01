using Business.Concretes;
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
GetCarsDetailsTest(carManager);


///////////////////////////////////////////////////////////////////

//ColorAddTest(colorManager);
//ColorDeleteTest(colorManager);
//ColorUpdateTest(colorManager);
//ColorGetAllTest(colorManager);
//GetColorByIdTest(colorManager);

///////////////////////////////////////////////////////////////////

//BrandAddTest(brandManager);
//BrandDeleteTest(brandManager);
//BrandUpdateTest(brandManager);
//BrandGetAllTest(brandManager);
//GetBrandByIdTest(brandManager);


static void CarAddTest(CarManager carManager)
{
    Car car1 = new Car();
    car1.BrandId = 2;
    car1.ColorId = 1;
    car1.CarName = "Bmw";
    car1.ModelYear = 2023;
    car1.DailyPrice = 10560;
    car1.Description = "Description";

    carManager.Add(car1);
}
static void DeleteCarTest(CarManager carManager)
{
    Console.WriteLine("--------------Deleted Cars----------------------");

    foreach (var car in carManager.GetCarsByBrandId(2))
    {
        Console.WriteLine(car.CarName);
        carManager.Delete(car);
    }

    foreach (var car in carManager.GetAll())
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


    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine("{0},{1}", car.Id, car.CarName);
    }
}
static void GetCarsByBrandIdTest(CarManager carManager)
{
    Console.WriteLine("--------------GetCarsByBrandId == 2----------------------");

    foreach (var car in carManager.GetCarsByBrandId(2))
    {
        Console.WriteLine(car.CarName);
    }
}
static void GetCarsByColorId(CarManager carManager)
{
    Console.WriteLine("--------------GetCarsByColorId == 1----------------------");


    foreach (var car in carManager.GetCarsByColorId(1))
    {

        Console.WriteLine(car.CarName);
    }
}
static void GetCarsDetailsTest(CarManager carManager)
{
    Console.WriteLine("--------------GetCarDetails----------------------");

    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName);
    }
}


static void ColorAddTest(ColorManager colorManager)
{
    Color color1 = new Color();
    color1.ColorName = "Beyaz";
    colorManager.Add(color1);
}
static void ColorDeleteTest(ColorManager colorManager)
{
    foreach (var color in colorManager.GetColorById(1002))
    {
        colorManager.Delete(color);
    }
}
static void ColorUpdateTest(ColorManager colorManager)
{
    foreach (var color in colorManager.GetColorById(1004))
    {
        color.ColorName = "Gri";
        colorManager.Update(color);
    }
}
static void ColorGetAllTest(ColorManager colorManager)
{
    Console.WriteLine("--------------ColorGetAll----------------------");

    foreach (var color in colorManager.GetAll())
    {   
        Console.WriteLine(color.ColorName);
    }
}
static void GetColorByIdTest(ColorManager colorManager)
{
    Console.WriteLine("--------------GetColorById == 1----------------------");

    foreach (var color in colorManager.GetColorById(1))
    {
        Console.WriteLine(color.ColorName);
    }
}


static void BrandAddTest(BrandManager brandManager)
{
    Brand brand1 = new Brand();
    brand1.BrandName = "Volkswagen";
    brandManager.Add(brand1);
}
static void BrandDeleteTest(BrandManager brandManager)
{
    foreach (var brand in brandManager.GetBrandById(1006))
    {
        brandManager.Delete(brand);
    }
}
static void BrandUpdateTest(BrandManager brandManager)
{
    foreach (var brand in brandManager.GetBrandById(1007))
    {
        brand.BrandName = "Skoda";
        brandManager.Update(brand);
    }
}
static void BrandGetAllTest(BrandManager brandManager)
{
    Console.WriteLine("--------------GetAllBrand----------------------");

    foreach (var brand in brandManager.GetAll())
    {
        Console.WriteLine(brand.BrandName);
    }
}
static void GetBrandByIdTest(BrandManager brandManager)
{
    Console.WriteLine("--------------GetBrandById == 1 ----------------------");

    foreach (var brand in brandManager.GetBrandById(1))
    {
        Console.WriteLine(brand.BrandName);
    }
}

