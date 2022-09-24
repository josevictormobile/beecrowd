using System.Linq.Expressions;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Data;
using Internal;
using System; 

class URI {

    static void Main(string[] args) { 

        int m,n;
        List<int> mList = new List<int>();
        List<int> nList = new List<int>();
        string line;
        do{
          line = Console.ReadLine();
          m = int.Parse(line.Split(' ')[0]);
          n = int.Parse(line.Split(' ')[1]);
          mList.Add(m);
          nList.Add(n);
        }
        while(m>0&&n>0);
       
        for(int i=0;i<mList.Length-1;i++){
          printOrderedAndSum(mList[i],nList[i]);
        }

        Console.Read();
    }

    static void printOrderedAndSum(int n, int m){
      int sum;
      string finalprint;

      if(n>m){
        for(int i=m;i<=n;i++){
          sum+=i;
          finalprint += $"{i} ";
        }
        finalprint +=sum;
        System.Console.WriteLine(finalprint);
      }else{
        for(int i=n;i<=m;i++){
          sum+=i;
          finalprint += $"{i} ";
        }
        finalprint +=sum;
        System.Console.WriteLine(finalprint);
      }
    }

}