public class AirCompressor : Machine
{
    public AirCompressor()
    {
        this.Max = 30;
        this.Price = 100;//quantidade para comprar a maquina
        this.IsBroken = false;//maquina quebreada?
        this.Click = 2;//quantidade de clicks produzidos por segundo
    }

    public override Machine Clone()
    {
        AirCompressor air = new AirCompressor();

        air.Max = this.Max;
        air.Price = this.Price;
        air.IsBroken = this.IsBroken;
        air.Click = this.Click;

        return air;
    }

    public override void Historic()
    {
        throw new NotImplementedException();
    }
}