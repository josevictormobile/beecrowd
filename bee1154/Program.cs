//assinando autoria pois novamente fiz push desse conteudo com outra conta
Console.WriteLine(RecursiveSolution(0,0).ToString("N2")); 
double RecursiveSolution(double sum, int amount){
    int age = Convert.ToInt32(Console.ReadLine());
    if(age<0){
        return sum/amount;
    }
    sum += age;
    amount++;
    return RecursiveSolution(sum,amount);
}