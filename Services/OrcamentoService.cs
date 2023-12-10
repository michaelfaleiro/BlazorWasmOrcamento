using BlazorWasmOrcamento.Models;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace BlazorWasmOrcamento.Services
{
    public class OrcamentoService(NavigationManager navigationManager, HttpClient httpClient) : IOrcamentoService
    {
        private readonly HttpClient _http = httpClient;
        private readonly NavigationManager _navigationManager = navigationManager;



        public List<Orcamento> Orcamentos { get; set; } = [];

        public async Task AddProdutoOrcamentoAsync(Produto produto)
        {
            await _http.PostAsJsonAsync("orcamentos/addproduto", produto);
        }

        public async Task CreateOrcamentoAsync(Orcamento orcamento)
        {
            await _http.PostAsJsonAsync("orcamentos", orcamento);
        }

        public async Task DeleteOrcamento(Guid id)
        {
            await _http.DeleteAsync($"orcamentos/{id}");
            _navigationManager.NavigateTo("orcamentos");

        }

        public async Task GetOrcamentoAsync()
        {
            var result = await _http.GetFromJsonAsync<List<Orcamento>>("orcamentos");
            if (result is not null)
            {
                Orcamentos = result;
            }
        }



        public async Task<Orcamento?> GetOrcamentoById(Guid id)
        {
            var result = await _http.GetAsync($"orcamentos/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Orcamento>();
            }
            return null;
        }

        public async Task RemoveProdutoOrcamentoAsync(Guid id)
        {
            await _http.DeleteAsync($"orcamentos/removeproduto/{id}");
        }
    }
}
