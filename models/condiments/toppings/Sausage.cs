public class Sausage : ToppingDecorator {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property implementations
    public override string _description {
        get{
            return additivefood._description + ", Sausage";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 3.4;
        }
        set{
        }
    }

    //Constructor
    public Sausage(Food food) {
        additivefood = food;
    }
}