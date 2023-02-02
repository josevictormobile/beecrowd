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


def RecursiveSolution(sum, amount):
    age = int(input())
    if age < 0:
        return sum/amount
    sum += age
    amount+=1
    return RecursiveSolution(sum,amount)
print(str(RecursiveSolution(0,0)))


