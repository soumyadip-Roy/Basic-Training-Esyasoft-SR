#List Example where all the elements need not be the same
a = ["banana", "apple", 12, 12.1]
print(type(a))
print(type (a[1]))
print(type (a[2]))
print("The elements are the same: "+str(type (a[2]) == type (a[1])))

#Dictionary example

b = {
    "name": "sRoy",
    "id": "1",
    "dob": "1/4/02"
}

print(type(b))
print(b)
print(b["name"])
print(type(b["name"]))

##conditional statements

#if cases
age = int(input())

if age >= 18:
    print("U can vote")
else:
    print("U cant vote")
    
#if-elif cases
power= int(input())

if power < 100: print("U are eligible for concessions")
elif power == 100: print("U are just eligible for concessions")
else:  print("U are not eligible for concessions")

##Loops 

#for  example

for i in a[1:]:
    print(i)


#while example 
cnt=0
while(cnt<3):
    cnt+=1
    if cnt == 1:continue
    print("done")
    if cnt == 2:break


