using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetColorById(int id);
        public void Add(Color color);
        public void Update(Color color);
        public void Delete(Color color);
    }
}
