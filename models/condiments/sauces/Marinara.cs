public class Marinara : Food {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property implementations
    public override string _description {
        get{
            return additivefood._description + ", Marinara";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 2.0;
        }
        set{
        }
    }

    //Constructor
    public Marinara(Food food){
        additivefood = food;
    }
}