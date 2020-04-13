import glob
import json

logFile = glob.glob("logs/*")
print(logFile)

d = {}

for fs in logFile:
    data = json.load(open(fs))
    for student in data["students"]:
       # print(student)
        d[student] = d[student]+1 if student in d.keys() else 1

sortedNames = sorted(d, key=d.get, reverse=True)

print("Looking at " + str(len(logFile)) + " meetings ")
print(sortedNames[0] + " had the most attendence with " + str(d[sortedNames[0]]) + " meetings")
print("-----------------------------------------------------------")
for name in sortedNames:
    print(name + ": " + str(d[name]) + " meetings " + str(round((d[name]/len(logFile)) * 100)) + "%")
