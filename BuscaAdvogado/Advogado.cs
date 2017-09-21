using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaAdvogado
{
    class Advogado
    {
        private String nome;
        private List<Inscricao> inscricoes;

        public Advogado(String nome)
        {
            inscricoes = new List<Inscricao>();
            this.nome = nome;
        }

        public void addInscricao(Inscricao inscricao)
        {
            inscricoes.Add(inscricao);
        }
    }
}
