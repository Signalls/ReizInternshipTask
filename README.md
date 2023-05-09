# Reiz
Task 1: 
This program defines a class called "Branch" which represents a node in a tree-like structure. 
Each branch has a name and a list of child branches. The program also includes a method called "CalculateDepth" which calculates the depth of the branch within the tree.

The thought behind this program is to recursively calculate the depth of a branch by traversing its child branches. 
It follows a depth-first search approach to determine the maximum depth of the tree.

The "CalculateDepth" method works as follows:

It first checks if the current branch is a leaf node (i.e., it has no child branches). 
If it is a leaf, it returns 1, indicating a depth of 1.
If the current branch has child branches, it recursively calls the "CalculateDepth" 
method on each child branch and keeps track of the maximum depth obtained from the child branches.
Finally, it adds 1 to the maximum depth obtained from the child branches to account for the current node and returns the result.
In summary, this program allows you to calculate the depth of a branch within a tree-like structure by 
recursively traversing its child branches and keeping track of the maximum depth.

Task 2:
The purpose of the "LesserAngle" class is to calculate the lesser angle between the hour and minute hands of a clock given the time in hours and minutes.

The "calculateLesserAngle" method takes two parameters: "hour" (representing the hour hand position) and "minute" (representing the minute hand position).
It returns the lesser angle between the hour and minute hands.

Here's how the method works:

It initializes the variable "angle" to 0.
It calculates the angle made by the hour hand using the formula: (hour % 12 + minute / 60.0) * 30. This considers both the hour and minute positions to determine the angle.
It calculates the angle made by the minute hand using the formula: minute * 6. Since each minute represents 6 degrees in a clock, multiplying the minutes by 6 gives the angle.
It calculates the difference between the two angles using the Math.Abs() method to ensure a positive value.
It checks if the angle is greater than 180 degrees. If it is, it subtracts the angle from 360 to get the lesser angle.
Finally, it returns the lesser angle.
In summary, this class and method allow you to calculate the lesser angle between the hour and minute hands of a clock based on the given hour and minute positions.
