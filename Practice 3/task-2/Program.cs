using System.IO;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"boot.ini");
            StreamWriter writer = new StreamWriter(@"boot-utf7.txt", false, System.Text.Encoding.UTF7);

            writer.WriteLine(reader.ReadToEnd());
            
            writer.Close();
            reader.Close();
        }
    }
}
