using Internal;
using System; 

class URI {
    
    public static string EvenOrOdd(int n){
        if(n==0){
            return "";
        }
        string answear="";
        int x = Convert.ToInt32(Console.ReadLine());
        if(n==1){
            if(x%2==0 && x>0){
                answear = "EVEN POSITIVE";
            }
            if(x%2!=0 && x>0){
                answear = "ODD POSITIVE";
            }
            if(x%2==0 && x<0){
                answear = "EVEN NEGATIVE";
            }
            if(x%2!=0 && x<0){
                answear = "ODD NEGATIVE";
            }
            if(x==0){
                answear = "NULL";
            }
        }else{
            if(x%2==0 && x>0){
                answear = "EVEN POSITIVE\n";
            }
            if(x%2!=0 && x>0){
                answear = "ODD POSITIVE\n";
            }
            if(x%2==0 && x<0){
                answear = "EVEN NEGATIVE\n";
            }
            if(x%2!=0 && x<0){
                answear = "ODD NEGATIVE\n";
            }
            if(x==0){
                answear = "NULL\n";
            }
        }
        return answear + EvenOrOdd(n-1);    
        
    }

    static void Main(string[] args) { 
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(EvenOrOdd(n));
        Console.ReadLine();
    }

}