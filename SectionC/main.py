
#Please use python 3.8 
print(sum(map(lambda x : (a:=x.split("|"), int(a[-2]) * ((a[7] == "FullTime") + (int(a[3].split("/")[-1]) > 1995) == 2) * 0.85)[1], open("HRMasterlistB.txt", "r").read().split("\n")[:-1])))
