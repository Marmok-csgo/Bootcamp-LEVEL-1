public class Car
{
    public string Model;   
    public string Make;

    public Car(string model, string make)
    {
        Model = model;
        Make = make;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Model.GetHashCode();
        hash = hash * 23 + Make.GetHashCode();
        return hash;
    }

    public override bool Equals(object obj)
    {
        if(obj is Car car)
            return car.GetHashCode() == obj.GetHashCode();

        return false;
    }
}