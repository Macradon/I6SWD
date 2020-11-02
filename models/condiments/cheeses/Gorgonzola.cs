public class Gorgonzola : Food {
    //Reference to a Food object
    private Food additivefood {get;set;}

    //Property implementations
    public override string _description {
        get{
            return additivefood._description + ", Gorgonzola";
        }
        set{
        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 4.8;
        }
        set{
        }
    }

    //Constructor
    public Gorgonzola(Food food){
        additivefood = food;
    }
}