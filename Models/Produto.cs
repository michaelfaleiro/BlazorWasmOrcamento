﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWasmOrcamento.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; } = 1;
        public string? Sku { get; set; }
        [MinLength(3, ErrorMessage = "Informe no mínimo 3 caracteres")]
        public string NomeProduto { get; set; } = string.Empty;
        public string? Marca { get; set; }
        public double PrecoCusto { get; set; } = 0;
        public double PrecoVenda { get; set; } = 0;
        public string? Link { get; set; }
        public string? Observacao { get; set; }
        public Guid OrcamentoId { get; set; }
        public Orcamento? Orcamento { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
