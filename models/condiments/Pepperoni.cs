public class Pepperoni : ToppingDecorator {
    public override string _description {
        get{
            return additivefood._description + ", Pepperoni";
        }
        set{

        }
    }
    public override double _cost {
        get{
            return additivefood._cost + 0.20;
        }
        set{
            
        }
    }

    private Food additivefood {get;set;}

    public Pepperoni(Food food) {
        additivefood = food;
    }
}