using System;
using System.Net.Http;


public class DeleteMethod
{
    static async Task Main(string[] args)
    {
        using (var client = new HttpClient()) 
        {
            HttpResponseMessage response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Successfully deleted!!! {response.StatusCode}");
            }

            else
            {
                Console.WriteLine($"Error has occured: {response.StatusCode}");
            }
        }
    }
}
