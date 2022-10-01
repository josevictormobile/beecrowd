using System; 

class URI {

    static void Main(string[] args) { 
        var resposta = Quadrant();
        Console.WriteLine(resposta.Remove(resposta.Length - 1));
    }

    static string Quadrant(){
        var linha = Console.ReadLine();
        var x = int.Parse(linha.Split (' ')[0]);
        var y = int.Parse(linha.Split(' ')[1]);
        if(x==0||y==0){
            return "";
        }
        if(x>0 && y>0){
            return "primeiro\n"+Quadrant();
        }
        if(x>0 && y<0){
            return "quarto\n"+Quadrant();
        }
        if(x<0 && y<0){
            return "terceiro\n"+Quadrant();
        }
        if(x<0 && y>0){
            return "segundo\n"+Quadrant();
        }
        return "";
    }
}