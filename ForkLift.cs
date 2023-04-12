public class ForkLift : Machine
{
    public ForkLift()
    {
        this.Max = 250;
        this.Price = 1500;//quantidade para comprar a maquina
        this.IsBroken = false;//maquina quebreada?
        this.Click = 25;//quantidade de clicks produzidos por segundo
    }
    public override Machine Clone()
    {
        ForkLift fLift = new ForkLift();

        fLift.Max = this.Max;
        fLift.Price = this.Price;
        fLift.IsBroken = this.IsBroken;
        fLift.Click = this.Click;

        return fLift;    }

    public override void Historic()
    {
        throw new NotImplementedException();
    }
}