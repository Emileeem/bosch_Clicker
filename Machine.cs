public abstract class Machine
{

    public int Max;
    public int Price;//quantidade para comprar a maquina
    public bool IsBroken;//maquina quebreada?
    public int Click;//quantidade de clicks produzidos

    public  void MaxReached (int max) //controle maximo alcançado da maquina
    {
        max = 0;

        this.Max = this.Max > max ? //se a quantidade maxima de maquina for maior que o maximo dessa funcao(corresponde ao maximo da maquina)
            this.Max : this.Max; //entao vai retornar apenas o maximo
        this.Max = this.Max > max ? //caso nao
            this.Max : max; //retorna o numero dessa funcao
    }
    


    public abstract void Historic ();//quantidade produzida
    public abstract Machine Clone ();

     public override string ToString()
    {
        return
        "╔=================================╗\n" +
        $"                                 |\n" +
        "╚================================";
    }
}