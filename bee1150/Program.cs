int x = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int answear = 0;
while(z<=x){
    z = Convert.ToInt32(Console.ReadLine());
}
for(int i=0;sum<=z;i++){
    sum += x+i;
    answear = i;
}
answear+=1;
Console.WriteLine(answear);