using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetAllById(int Id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
