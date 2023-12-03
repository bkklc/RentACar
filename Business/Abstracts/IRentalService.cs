using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalById(int id);
        IDataResult<List<Rental>> GetRentalByCustomerId(int id);
        IDataResult<List<Rental>> GetRentalByCarId(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
