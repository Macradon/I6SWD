public class Gorgonzola : ToppingDecorator
{
    //Constructor
    public Gorgonzola(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Gorgonzola";
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