using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1;

public sealed class BMW : CarRental
{
    public BMW(string modelname)
        :base("BMW")
    {
        ModelName = modelname;
    }

    public string ModelName { get; init; }
    public const int RentPricePerHour = 20;
}

