public class Pepperoni : ToppingDecorator
{
    //Constructor
    public Pepperoni(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Pepperoni";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return _additiveFood._cost + 10.00;
        }
        set{
        }
    }
}