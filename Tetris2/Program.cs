namespace Tetris2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.Write("Select 1-3 (1-Multidimensional Arr, 2-Jagged Arr, 3-Structure Arr) : ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    MultidimensionalArray v1 = new MultidimensionalArray();
                    v1.Run();
                    break;
                case 2:
                    JaggedArray v2 = new JaggedArray();
                    v2.Run();
                    break;
                case 3:
                    StructureArray v3 = new StructureArray();
                    v3.Run();
                    break;
                default: 
                    Console.WriteLine("You haven't selected any mode (1-3). Program ends now...");
                    break;

            }

            Console.ReadKey();
        }
    }
}