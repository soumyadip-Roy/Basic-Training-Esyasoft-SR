print("Plese enter the number of Coordinates you would like to check")
num = int(input())
points=[]
print("Please enter the coordinate values in the formay XY for (X,Y) values to be stored")
for i in range(num):
    print(f"Please enter the X ordinate for {i} coordinates:")
    userXCoord = int(input())
    print(f"Please enter the Y ordinate for {i} coordinates:")
    userYCoord = int(input())
    points.append((userXCoord,userYCoord))
# print(a)

for (x,y) in points:
    print((x,y))
    if(int(x)>int(y)):print("X is greater than Y")
    else:print("Y is greater than or equal to X")

    