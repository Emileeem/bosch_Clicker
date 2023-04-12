public class Machinery {

    private Machine[] mac = new Machine[10000]; //deixando comprar apenas 10000 maquinas

    public override string ToString()
    {
        string str = "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
                     "▓▓               Seu              ▓▓\n" +
                     "▓▓            Maquinário!         ▓▓\n" +
                     "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n\n";        

        for(int i = 0; i < mac.Length; i++)
            str += (mac[i]?.ToString() ?? "(██Vazio██)") + "\n";
        return str;        
    }
    public void Add(Machine mach)//toda vez que compro uma maquina é adicionada ao meu maquinario 
    {
        for (int i = 0; i < 1000; i++)
        {
            if(mac[i] != null)
                continue;
            
            mac[i] = mach;
            break;
        }
    }
}