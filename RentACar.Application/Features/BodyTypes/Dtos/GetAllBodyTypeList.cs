using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Dtos
{
    public class GetAllBodyTypeList
    {
        public IList<BodyTypeListItemDto> BodyTypeLists { get; set; }
    }
}
