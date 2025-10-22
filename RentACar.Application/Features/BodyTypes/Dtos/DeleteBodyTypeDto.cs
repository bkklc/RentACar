using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.BodyTypes.Dtos
{
    public class DeleteBodyTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
