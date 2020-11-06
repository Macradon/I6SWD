public abstract class ToppingDecorator : Food
{
    public ToppingDecorator()
    {

    }

    public Food _additiveFood {get;set;}
    public abstract override string _description {get;set;}
    public abstract override double _cost {get;set;}
}