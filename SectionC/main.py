
def main():

    #print((lambda c : __import__("functools").reduce(lambda a, b: a+float(b[-2]), c, 0))(list(map(lambda x : (a := x.split("|"), a.__setitem__(8, str(int(a[-2]) * 0.85) if (a[7] == "FullTime" and a[3].split("/")[-1]) else a[8]), print("|".join(a)))[0], read_file("HRMasterlistB.txt").split("\n")[:-1]))))


    #option 1 (Longest but statementless, uses vareity of techniques)
    print(__import__("functools").reduce(lambda a, b: a+float(b[-2]) * 0.85, filter(lambda x: (x[7] == "FullTime") + (int(x[3].split("/")[-1]) > 1995) == 2,  map(lambda x : x.split("|"), open("HRMasterlistB.txt", "r").read().split("\n")[:-1])), 0))

    #option 2 (Shortest idea, 1 statement)
    print(sum(map(lambda x : (a:=x.split("|"), int(a[-2]) * ((a[7] == "FullTime") + (int(a[3].split("/")[-1]) > 1995) == 2) * 0.85)[1], open("HRMasterlistB.txt", "r").read().split("\n")[:-1])))

    #option 3 (Second shortest, inefficient but statementless)
    print(sum(map(lambda x : (int(x.split("|")[-2]) * ((x.split("|")[7] == "FullTime") + (int(x.split("|")[3].split("/")[-1]) > 1995) == 2) * 0.85), open("HRMasterlistB.txt", "r").read().split("\n")[:-1])))
  
    
main()