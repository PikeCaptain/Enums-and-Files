namespace Enums_and_Files
{

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Sets birth month
            int myBirthMonth = (int)Months.Oct;
            //Sets birth day
            int myBirthDay = 12;
            //Set birht year
            int myBirthYear = 2006;

            //tells when the BirthDate is by calling the month, day, and year
            string myBirthDate = $"My birhtday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myfile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}
