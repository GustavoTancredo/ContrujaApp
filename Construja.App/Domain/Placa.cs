using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construja.App.Domain
{
     public class Placa
    {
        public Placa(int pId, DateTime pDataHora, string pPlaca, int pQtdCaixaSaida, int? pQtdCaixaRetorno, string pObservacao)
        {
            Id = pId;
            DataHora = pDataHora;
            placa = pPlaca;
            qtdCaixaSaida = pQtdCaixaSaida;
            qtdCaixaRetorno = pQtdCaixaRetorno;
            Observacao = pObservacao;
        }

        public Placa(DateTime DataHora,string Placa,int QtdCaixaSaida)
        {
                this.DataHora = DataHora;
                this.placa = Placa;
                this.qtdCaixaSaida = QtdCaixaSaida;
        }

        public Placa()
        {
                
        }
        public int Id { get; set; }
        public System.DateTime DataHora { get; set; }
        public string placa { get; set; }
        public int qtdCaixaSaida { get; set; }
        public Nullable<int> qtdCaixaRetorno { get; set; }
        public string Observacao { get; set; }
    }
}
