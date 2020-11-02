public class Mayonnaise : Food {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property implementations
    public override string _description {
        get{
            return additivefood._description + ", Mayonnaise";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 3.7;
        }
        set{
        }
    }

    //Constructor
    public Mayonnaise(Food food){
        additivefood = food;
    }
}