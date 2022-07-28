class Program
{
    static void Main()
    {
        // Three source arrays.
        var array1 = new int[] { 1, 2, 3, 4, 5 };
        var array2 = new int[] { 6, 7, 8, 9, 10 };
        var array3 = new char[] {'a', 'b', 'c', 'd', 'e'};

        // Add elements at each position together.
        var zipped = array1.Zip(array2, (a, b) => new {a, b}).Zip(array3, (c, d) => new {AA = c.a, BB = c.b, CC = d});
        // Zip method uses lambda expression after '=>'

        // Look at results.
        foreach (var value in zipped)
        {
            // Access the elements in the zipped lists
            string A = value.AA.ToString();
            string B = value.BB.ToString();
            char C = value.CC;
            var toPrint = String.Join(", ", A, B, C);
            var formatted = String.Format("United: {0}", toPrint);
            Console.WriteLine(formatted);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

    }
}