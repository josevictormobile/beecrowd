string input = Console.ReadLine();
string[] input_array = input.Split(' ');
int x = Convert.ToInt32(input_array[0]);
int y = Convert.ToInt32(input_array[1]);

for(int i=1;i<=y;i++){
    
    if(i%x==0){
        Console.Write(i + "\n");
    }else{
        Console.Write(i + " ");
    }
        
}
