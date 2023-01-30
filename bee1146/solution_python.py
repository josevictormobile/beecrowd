result = ""
        
while True:
    x = int(input())
    if x == 0:
        break
    if result != "":
        result += "\n"
    i=1
    while i < x:
        result += str(i) + " "
        i+=1
    result += str(x)
        
print(result) 
