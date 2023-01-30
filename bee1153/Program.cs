int n = Convert.ToInt32(Console.ReadLine());
int result =1;
for(int i=n;i>0;i--){
    result*=i;
}
Console.WriteLine(result);