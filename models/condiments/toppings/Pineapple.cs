public class Pineapple : ToppingDecorator 
{
    //Constructor
    public Pineapple(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Pineapple";
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