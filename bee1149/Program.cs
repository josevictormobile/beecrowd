string input = Console.ReadLine();
string[] inputs = input.Split(' ');
int a = Convert.ToInt32(inputs[0]);
int n = 0;
int sum = 0;
for(int i=1;i<inputs.Length;i++){
    if(Convert.ToInt32(inputs[i])>0){
        n = Convert.ToInt32(inputs[i]);
        break;
    }
}

for(int i=0;i<n;i++){
    sum +=a+i;
}
System.Console.WriteLine(sum);
