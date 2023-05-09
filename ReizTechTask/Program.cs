using ReizTechTask;

Console.Write("Enter the hour (1-12): ");
int hour = int.Parse(Console.ReadLine());

Console.Write("Enter the minute (0-59): ");
int minute = int.Parse(Console.ReadLine());

var result = LesserAngle.calculateLesserAngle(hour, minute);

Console.WriteLine($"The lesser angle between the hour hand and minute hand is {result} degrees.");






//Create a hierarchical structure
Branch root = new Branch("Root");
Branch branch1 = new Branch("Branch 1");
Branch branch2 = new Branch("Branch 2");
Branch branch3 = new Branch("Branch 3");
Branch branch4 = new Branch("Branch 4");
Branch branch5 = new Branch("Branch 5");

root.branches.Add(branch1);
root.branches.Add(branch2);
branch1.branches.Add(branch3);
branch1.branches.Add(branch4);
branch3.branches.Add(branch5);

//Calculate the depth of the structure
int depth = Branch.CalculateDepth(root);

Console.WriteLine($"The depth of the structure is {depth}.");

