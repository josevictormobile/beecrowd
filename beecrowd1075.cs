using System; 
using Internal;
class URI {

    static void Main(string[] args) { 
        int n;
        n=Convert.ToInt32(Console.ReadLine());
        for(int i=2;i<10000;i++){
            if(i%n==2){
                Console.WriteLine(i);
            }
        }
    }

}