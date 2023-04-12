using System;
using static System.Console;

public class Shop
{
    public int BicoInjetor {get; set;} = 0;
    public List <Machine> machines = new List <Machine>(); //criando a lista para gerar novas maquinas

    private List <Machine> baseMachines = new List <Machine>(); //maquinas de base para serem clonadas

    public void Click()
    {
        this.BicoInjetor += 1;
    }

    Machinery mach = new Machinery();//abrindo maquinario para conseguir adicionar logo abaixo as maquinas que serao compradas

    public void Buy (int index, Machine mac) //ao comprar as maquinas
    {

        if(BicoInjetor < mac.Price) //se o total dos nossos bicos injetores for menor que o preço da maquina
            return; // retorna
        
        var bought = machines[index];
        BicoInjetor -= mac.Price; //reduz o total dos nossos bicos injetores pelo preco total da maquina que comprar
        mach.Add(bought); //adicionando nossa maquina no maquinario
    }

    public void Add(Machine baseMachines)
        => this.baseMachines.Add(baseMachines);

    public void Macs()
    {
        AirCompressor air = new AirCompressor();
        VacuumSealer vac = new VacuumSealer();
        ForkLift forl = new ForkLift();

        machines.Clear();//dando clear para limpar as máquinas caso duplique ou algo do genero?
        machines.Add(air.Clone());//clonando uma maquina compressora de ar para aparecer na nossa loja
        machines.Add(vac.Clone()); //clonando uma maquina de vacuum para aparecer na nossa loja
        machines.Add(forl.Clone()); //clonando uma empilhadeira para aparecer na nossa loja
    }

    public override string ToString()
    {
        string str = $"Loja (Dinheiro: {BicoInjetor})\n";
        for(int i = 0; i < machines.Count; i++)
            str += machines[i].ToString() + "\n";
        return str;
    }
}