using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoExemploHTTP.Models;
using System.Windows.Input;


namespace ProjetoExemploHTTP.ViewModels
{
    public partial class ProjetoExemploHTTPViewModel : ObservableObject
    {
        private readonly RestService _restService;

        public ProjetoExemploHTTPViewModel() 
        {
           CriarPostagem = new Command (async () => await
           GetPostagensAsync());
            _restService = new RestService();
        }

       /* [ObservableProperty]
        private int _userId;
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _title;
        [ObservableProperty]
        private string _body; */

        private ObservableCollection<Postagem> _postagens = new ObservableCollection<Postagem>();
        public ObservableCollection<Postagem> Postagens
        {
            get { return _postagens; } 
            set { _postagens = value;}
        }

        public ICommand CriarPostagem { get; }
        
        public async Task<ObservableCollection<Postagem>> GetPostagensAsync()
        {
            return await _restService.GetPostagensAsync();
        }
    }
}
