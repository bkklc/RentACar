using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Brands.Dtos
{
    public class GetAllBrandList
    {
        public IList<BrandListItemDto> BrandLists { get; set; }
    }
}
