namespace SnowSpaceLogic;

public class RocketShip
{
    public readonly string Name;

    public RocketShip(string Name)
    {
        this.Name = Name;
    }
    public string TakeOff()
    {
        if (Name == "Doomed")
        {
            return "Boom!";
        }
        return $"{Name}shhhsjdfkjskldjf";
    }
}
