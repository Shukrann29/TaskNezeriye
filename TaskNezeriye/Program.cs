using System.Net;
using System.Text.Json;

namespace TaskNezeriye
{
    internal class Program
    {
        static async void Main(string[] args)
        { 
          

             string path = "C:\\Users\\Slymnf\\source\\repos\\TaskNezeriye\\TaskNezeriye\\TaskNezeriye.csproj";
              DirectoryInfo directoryInfo = new DirectoryInfo(path + @"\Users");
              if (!directoryInfo.Exists)
              {
                  directoryInfo.Create();
                  Console.WriteLine("Users directory exists");
              }
              else
                  Console.WriteLine("Directory created");
              FileInfo File = new FileInfo(path + @"\Users\users.json");
              File.Create();
              HttpClient client = new HttpClient();
              HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
  
         
        
        }
    }
}
