using N17_HT1;
public class CarRentalManagement
{
    private readonly Dictionary<Guid, CarRental> _cars;


    public CarRentalManagement()
    {
        _cars = new Dictionary<Guid, CarRental>();
    }

    public void Add(CarRental car)
    {
        _cars[car.Id] = car;
    }

    public CarRental Rent(string modelname)
    {
        foreach (var car in _cars.Values)
        {
            if(!car.IsRented && car is BMW bmw && bmw.ModelName.Contains(modelname, StringComparison.OrdinalIgnoreCase))
            {
                car.IsRented = true;
                car.RentStartTime = DateTime.Now;
                return bmw;
            }

            if(!car.IsRented && car is Audi audi && audi.ModelName.Contains(modelname, StringComparison.OrdinalIgnoreCase))
            {
                car.IsRented = true;
                car.RentStartTime = DateTime.Now;
                return audi;
            }
        }
        Console.WriteLine("Uzr, hozirda ijaraga mashina yo'q.");
        return null;
    }



    public void Return(CarRental car)
    {
        if(!_cars.ContainsKey(car.Id) || !_cars[car.Id].IsRented)
        {
            throw new ArgumentException("This car does not exist.");
        }

        var totalRentTime = (DateTime.Now - _cars[car.Id].RentStartTime).TotalSeconds;

        if (car is BMW)
        {
            car.Balance += totalRentTime * BMW.RentPricePerHour;
        }
        else if(car is Audi)
        {
            car.Balance += totalRentTime * Audi.RentPricePerHour;
        }

        _cars[car.Id].IsRented = false;
        
    }


    public double CalculateBalance()
    {
        double balance = 0;
        foreach(var car in _cars.Values)
        {
            balance += car.Balance;
        }

        return Math.Round(balance, 2);
    }
}