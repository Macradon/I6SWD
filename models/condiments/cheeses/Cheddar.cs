public class Cheddar : ToppingDecorator
{
    //Constructor
    public Cheddar(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Cheddar";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return _additiveFood._cost + 5.00;
        }
        set{
        }
    }
}