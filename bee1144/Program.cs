int lines = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=lines*2;i++){
    if(i%2==0){
        Console.WriteLine($"{i} {i*i+1} {i*i*i+1}");
    }else{
        Console.WriteLine($"{i} {i*i} {i*i*i}");
    }
        
}//User josevictor who made this