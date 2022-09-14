using System; 

class URI {

    static void Main(string[] args) { 

       for (decimal i = 0m; i <= 2; i += 0.2m)
            {
                for (decimal j = 1; j < 4; j++)
                {
                    var istring = i.ToString();
                    var jstring = j.ToString();
                    var temSeparador = (istring.Contains(".") || istring.Contains(","));
                    var separador = (istring.Contains(".")) ? '.' : ',';
                    if (temSeparador)
                    {
                        
                        if(istring.Split(separador)[1] == "0")
                        {
                            Console.WriteLine($"I={istring.Replace(",0", "")} J={jstring.Split(separador)[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"I={istring.Replace(',', '.')} J={jstring.Split(separador)[0] + "." + istring.Split(separador)[1]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I={istring.Replace(',', '.')} J={jstring}");
                    }

                }

            }

    }

}