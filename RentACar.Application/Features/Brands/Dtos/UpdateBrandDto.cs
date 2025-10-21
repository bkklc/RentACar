using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Dtos
{
    public class UpdateBrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }       
        public DateTime UpdatedDate { get; set; }        
    }
}
