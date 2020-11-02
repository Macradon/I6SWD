public class Cheddar : Food {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property implementations
    public override string _description {
        get{
            return additivefood._description + ", Cheddar";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 3.9;
        }
        set{
        }
    }

    //Constructor
    public Cheddar(Food food){
        additivefood = food;
    }
}