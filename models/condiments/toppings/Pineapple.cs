public class Pineapple : ToppingDecorator {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property impementations
    public override string _description {
        get{
            return additivefood._description + ", Pineapple";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 3.5;
        }
        set{
        }
    }

    //Constructor
    public Pineapple(Food food) {
        additivefood = food;
    }
}