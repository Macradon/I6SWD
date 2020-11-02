public class Pepperoni : ToppingDecorator {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property impementations
    public override string _description {
        get{
            return additivefood._description + ", Pepperoni";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 4.4;
        }
        set{
        }
    }

    //Constructor
    public Pepperoni(Food food) {
        additivefood = food;
    }
}