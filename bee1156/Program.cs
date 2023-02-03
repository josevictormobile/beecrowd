//desenvolvido por josé victor
double denominator = 1;
double s = 0;
for(double numerator=1;numerator<=39;numerator+=2){
    s += numerator/denominator;
    denominator*=2;
    
}
System.Console.WriteLine(s.ToString("N2"));