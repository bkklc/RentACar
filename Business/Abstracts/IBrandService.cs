using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandById(int id);
        public void Add(Brand brand);
        public void Update(Brand brand);
        public void Delete(Brand brand);
    }
}
