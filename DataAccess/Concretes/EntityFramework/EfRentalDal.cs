using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Customers
                             join car in context.Cars
                             on c.Id equals car.Id
                             join r in context.Rentals
                             on c.Id equals r.CustomerId
                             join u in context.Users
                             on c.UserId equals u.Id

                             select new RentalDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CarName = car.CarName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }

        
    }
}
