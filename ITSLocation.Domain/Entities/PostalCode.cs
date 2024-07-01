using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSLocation.Domain.Entities
{
    public class PostalCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
