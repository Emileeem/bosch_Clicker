public class Game 
{
    public Shop MyShop {get; set;} = new Shop();//abrindo a loja no jogo

    public void Start()
    {
        MyShop.Add(new AirCompressor()); //caso compre adicionando ao machinery
        MyShop.Add(new VacuumSealer()); //caso compre adicionando ao machinery
        MyShop.Add(new ForkLift()); //caso compre adicionando ao machinery

        MyShop.Macs();
    }
    public override string ToString()
    {
        return 
            MyShop.ToString() + "\n";
    }
}