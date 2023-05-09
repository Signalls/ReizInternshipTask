namespace ReizTechTask
{
    public class Branch
    {
        public string _name;
        public List<Branch> branches;

        public Branch(string name)
        {
            _name = name;
            branches = new List<Branch>();
        }

        public static int CalculateDepth(Branch branch)
        {
            int maxDepth = 0;

            // Base case: leaf node
            if (branch.branches.Count == 0)
            {
                return 1;
            }

            // Recursive case: internal node
            foreach (Branch subbranch in branch.branches)
            {
                int subDepth = CalculateDepth(subbranch);
                if (subDepth > maxDepth)
                {
                    maxDepth = subDepth;
                }
            }

            // Add 1 to account for current node
            return maxDepth + 1;
        }
    }

}
