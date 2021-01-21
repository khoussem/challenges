## Descripotion

This repository holds the solutions of some of the challenges that exists in Hackerrank, leetcode and other similar websites, each problem is in a folder that contains a reference to the source of the problem and the input as a file named input.txt.

Also the file containing the solution code is named `Solution.cs` and the class is names `Solution` and is within a namespace that holds the same name as the problem.

## Run a code of a problem

There is a script `run.sh` that builds the project and run the problem, it does expect the main class to have the name `Solution` and be within the namespace `challenges.<ProblemName>`.
To run the code, change in the `input.txt` found in the problem folder and then run:

```
./run.sh <ProblemName>
```