
namespace TASK2
{
	internal class Program
	{
		static void Main(string[] args)
		{	bool flag = true;
			int number = 0;
			Console.WriteLine("Please enter new employee ");
			String employes = Console.ReadLine();
			do {

				Console.WriteLine("Do you want to continue? ");
				string answer = Console.ReadLine();
				if (answer == "yes")
				{
					Console.WriteLine("Please enter new employee ");
					String employe = Console.ReadLine();
				}
				else
				{
					flag = false;
					Console.WriteLine(employes);
				}
			} while (flag);
		}
	}
}