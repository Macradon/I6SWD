public class Bacon : ToppingDecorator
{
    //Constructor
    public Bacon(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Bacon";
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