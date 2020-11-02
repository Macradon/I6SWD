public class Bacon : ToppingDecorator {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property impementations
    public override string _description {
        get{
            return additivefood._description + ", Bacon";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 6.9;
        }
        set{
        }
    }

    //Constructor
    public Bacon(Food food) {
        additivefood = food;
    }
}