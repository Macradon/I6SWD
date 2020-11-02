public class Sandwich : Food {
    public override string _description {get;set;}
    public override double _cost {get;set;}

    public Sandwich(){
        _description = "A Calzon is top and bottom crusted dish with a spread and filling.";
        _cost = 9.56;
    }
}