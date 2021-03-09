using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeilaoOnline.Core
{
    public class OfertaSuperiorMaisProxima : IModalidadeAvaliacao
    {
        public double ValorDestino { get; set; }

        public OfertaSuperiorMaisProxima(double valorDestino)
        {
            ValorDestino = valorDestino;
        }

        public Lance Avaliacao(Leilao leilao)
        {
            return leilao.Lances.DefaultIfEmpty(new Lance(null,0)).Where(l => l.Valor > ValorDestino)
                    .OrderBy(l => l.Valor).FirstOrDefault(); ;
        }
    }
}
