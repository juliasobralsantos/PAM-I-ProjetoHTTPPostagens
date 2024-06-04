using ProjetoExemploHTTP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjetoExemploHTTP
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public ObservableCollection<Postagem> Postagens { get; set; }

        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions{
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<ObservableCollection<Postagem>> GetPostagensAsync()
        {
            Postagens = new ObservableCollection<Postagem>();

            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Postagens = JsonSerializer.Deserialize<ObservableCollection<Postagem>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            { 
                Debug.WriteLine(ex);
            }
            return Postagens ?? [];

        }
    }
}
