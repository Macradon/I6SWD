public class Mozzarella : ToppingDecorator 
{
    //Constructor
    public Mozzarella(Food food)
    {
        _additiveFood = food;
    }

    //Property implementations
    public override string _description {
        get{
            return _additiveFood._description + ", Mozzarella";
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