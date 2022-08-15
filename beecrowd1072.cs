using Internal;
using System; 

class URI {

    static void Main(string[] args) { 

        int n,dentro=0,fora=0,x;
        n = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++){
            x=Convert.ToInt32(Console.ReadLine());
            if(x>=10 && x<=20){
                dentro++;
            }else{
                fora++;
            }
        }
        Console.WriteLine("{0} in",dentro);
        Console.WriteLine("{0} out",fora);
        Console.Read();
    }

}