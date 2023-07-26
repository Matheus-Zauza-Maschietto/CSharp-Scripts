using System.Net.Http;
class Program
{
    public static void Main()
    {
        const string defaultPath = "https://cat-fact.herokuapp.com";

        using(HttpClient cliente = new HttpClient()){
            HttpResponseMessage respose = cliente.GetAsync(defaultPath+"/facts/random");
            System.Console.WriteLine(respose.body);
        }
    }
}
