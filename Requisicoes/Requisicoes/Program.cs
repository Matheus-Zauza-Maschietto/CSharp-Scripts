using System.Net.Http;
using System;

const string defaultPath = "https://cat-fact.herokuapp.com";

using (HttpClient cliente = new HttpClient())
{
    HttpResponseMessage respose = await cliente.GetAsync(defaultPath+"/facts/random");
    Console.WriteLine(respose.Content.Content);
}