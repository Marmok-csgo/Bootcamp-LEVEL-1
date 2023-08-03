using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1;
    public abstract class CarRental
    {

        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public double Balance { get; set; } = 0;
        public string BrandName { get; init; }
        public Guid Id { get; }

        public CarRental(string brandname)
        {
            BrandName = brandname;
            Id = Guid.NewGuid();
        }
    }
