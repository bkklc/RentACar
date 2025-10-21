using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Dtos
{
    public class CreatedBrandDto
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
