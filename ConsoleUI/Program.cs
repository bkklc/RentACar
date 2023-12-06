using Business.Concretes;
using Business.Constants;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using Microsoft.VisualBasic;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
UserManager userManager = new UserManager(new EfUserDal());
CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());

//GetCarsById(carManager);



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
/////////////////////////////////////////////

//UserAddTest(userManager);
//CustomerAddTest(customerManager);
//RentalAddTest(rentalManager);

//GetCustomerDetailsTest(customerManager);
//GetRentalDetailsTest(rentalManager);



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


static void UserAddTest(UserManager userManager)
{
    User user1 = new User
    {
        FirstName = "Berk",
        LastName = "Kılıç",
        Email = "a@gmail.com",
        Password = "Password",
    };
    userManager.Add(user1);
}
static void CustomerAddTest(CustomerManager customerManager)
{
    Customer customer1 = new Customer
    {
        UserId = 1,
        CompanyName = "KLC",
    };
    customerManager.Add(customer1);
}
static void RentalAddTest(RentalManager rentalManager)
{
    Rental rental1 = new Rental
    {
        CarId = 1,
        CustomerId = 1,
        RentDate = new DateTime(2023, 12, 2, 23, 45, 49),
        ReturnDate = new DateTime(2023, 12, 3, 23, 45, 49)
    };
    rentalManager.Add(rental1);
}
static void GetRentalDetailsTest(RentalManager rentalManager)
{
    var result = rentalManager.GetRentalDetails();

    if (result.Success == true)
    {
        foreach (var rental in result.Data)
        {
            Console.WriteLine(rental.FirstName + " " + rental.LastName);
            Console.WriteLine(rental.CarName + " " + rental.ModelYear + " " + rental.DailyPrice + " " + rental.RentDate + "/" + rental.ReturnDate);
        }
    }

    else Console.WriteLine(result.Message);
}
static void GetCustomerDetailsTest(CustomerManager customerManager)
{
    var result = customerManager.GetCustomerDetails();

    if (result.Success == true)
    {
        foreach (var customer in result.Data)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
        }
    }
    else Console.WriteLine(result.Message);
}

static void GetCarsById(CarManager carManager)
{
    Console.WriteLine("--------------GetCarsById----------------------");

    foreach (var car in carManager.GetCarsById(1).Data)
    {
        Console.WriteLine(car.CarName);
    }
}