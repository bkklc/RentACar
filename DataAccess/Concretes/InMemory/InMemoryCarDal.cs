using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1,BrandId = 1, ColorId = 1, CarName = "Audi", ModelYear = 2023, DailyPrice = 2375000, Description = "2023 model sıfır araba"},
                new Car { Id = 2,BrandId = 2, ColorId = 2,CarName = "Mercedes", ModelYear = 2018, DailyPrice = 2375000, Description = "2018 model  araba"},
                new Car { Id = 3,BrandId = 3, ColorId = 3,CarName = "Bmw", ModelYear = 2022, DailyPrice = 2375000, Description = "2022 model  araba"},
                new Car { Id = 4,BrandId = 4, ColorId = 4,CarName = "Volkswagen", ModelYear = 2021, DailyPrice = 2375000, Description = "2021 model  araba"},
                new Car { Id = 5,BrandId = 5, ColorId = 5,CarName = "Porsche", ModelYear = 2017, DailyPrice = 2375000, Description = "2017 model  araba"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car productToDelete = _cars.SingleOrDefault(c =>c.Id == car.Id);
            _cars.Remove(productToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();

        }     

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
