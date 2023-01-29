
string answear = RecursiveSolution();
Console.WriteLine(answear.Remove(answear.Length-1));
string RecursiveSolution(){
    string result = string.Empty;
    int x = Convert.ToInt32(Console.ReadLine());
    if(x==0){
        return string.Empty;
    }
    for(int i=1;i<=x;i++){
        if(i==x){
            result += i.ToString()+"\n";
        }else{
            result += i.ToString()+" ";
        }
    }
    return result + RecursiveSolution();
}//feito por jose victor