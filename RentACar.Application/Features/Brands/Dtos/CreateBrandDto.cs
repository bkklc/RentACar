using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Dtos
{
    public class CreateBrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
