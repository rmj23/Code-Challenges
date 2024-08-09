namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            IList<IList<int>> triangle = program.Generate(30);

            foreach (IList<int> row in triangle)
            {
                foreach (int num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            if (numRows == 0) return triangle;

            // First row is always [1]
            triangle.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                IList<int> prevRow = triangle[i - 1];
                IList<int> newRow = new List<int>();

                // First element of each row is always 1
                newRow.Add(1);

                // Generate the elements of the new row
                for (int j = 1; j < i; j++)
                {
                    var prevRowNum1 = prevRow[j - 1];
                    var prevRowNum2 = prevRow[j];

                    newRow.Add(prevRowNum1 + prevRowNum2);
                }

                // Last element of each row is always 1
                newRow.Add(1);

                // Add the new row to the triangle
                triangle.Add(newRow);
            }

            return triangle;
        }
    }
}
