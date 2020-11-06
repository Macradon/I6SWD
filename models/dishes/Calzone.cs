public class Calzone : Food
{
    //Constructor
    public Calzone()
    {
        _description = "Calzone";
        _cost = 55.00;
    }

    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}
}