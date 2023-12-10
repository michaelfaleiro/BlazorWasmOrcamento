using BlazorWasmOrcamento.Models;

namespace BlazorWasmOrcamento.Services
{
    public interface IOrcamentoService
    {
        List<Orcamento> Orcamentos { get; set; }
        Task GetOrcamentoAsync();

        Task CreateOrcamentoAsync(Orcamento orcamento);

        Task<Orcamento?> GetOrcamentoById(Guid id);

        Task DeleteOrcamento(Guid id);

        Task AddProdutoOrcamentoAsync(Produto produto);

        Task RemoveProdutoOrcamentoAsync(Guid id);
    }
}
