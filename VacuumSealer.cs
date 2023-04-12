public class VacuumSealer : Machine
{
    public VacuumSealer()
    {
        this.Max = 100;
        this.Price = 450;//quantidade para comprar a maquina
        this.IsBroken = false;//maquina quebreada?
        this.Click = 5;//quantidade de clicks produzidos por segundo
    }
    public override Machine Clone()
    {
        VacuumSealer vac = new VacuumSealer();

        vac.Max = this.Max;
        vac.Price = this.Price;
        vac.IsBroken = this.IsBroken;
        vac.Click = this.Click;

        return vac;
    }

    public override void Historic()
    {
        throw new NotImplementedException();
    }
}