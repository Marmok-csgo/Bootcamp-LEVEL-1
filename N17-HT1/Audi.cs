using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1;

public sealed class Audi : CarRental
{
    public string ModelName { get; init; }
    public const int RentPricePerHour = 20;

    public Audi(string modelName)
         : base("Audi")
    {
        ModelName = modelName;
    }
}
