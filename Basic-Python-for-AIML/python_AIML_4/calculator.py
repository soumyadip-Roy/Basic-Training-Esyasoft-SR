def add(a,b):
    return (a+b)

def subtract(a,b):
    return a-b

def multiply(a,b):
    return (a*b)

def division(a,b):
    return [a/b,a%b]

print("Please enter the operation you would like to run: ")
userOp = input()
if (userOp not in ['add','subtract','divide','multiply']): print('Command Not Recognised')
else:
    print("Please enter first number to be operated on (A): ")
    op1 = int(input())
    print("Please enter first number to operate by (B): ")
    op2 = int( input())

    if(userOp=='add'):print(int(add(op1,op2)))
    elif(userOp=='subtract'):print(int(subtract(op1,op2)))
    elif(userOp=='multiply'):print(int(multiply(op1,op2)))
    elif(userOp=='divide'):
        result = division(op1,op2)
        print('quotient: ', int(result[0]))
        print('remainder: ',int(result[1]))
    # else: print("command not recognized")


