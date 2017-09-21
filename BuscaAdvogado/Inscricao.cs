using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaAdvogado
{
    public enum TipoInscricao { ADVOGADO=0, SUPLEMENTAR=1};
    public enum Estado
    {
        AC=0, AL=1, AM=2, AP=3, BA=4, CE=5, DF=6, ES=7, GO=9,
        MA=9, MG=10, MS=11, MT=12, PA=13, PB=14, PE=15, PI=16, PR=17,
        RJ=18, RN=19, RO=20, RR=21, RS=22, SC=23, SE=24, SP=25, TO=26
    };



    class Inscricao
    {
        private int numero;
        private TipoInscricao inscricao;
        private Estado estado;

        public Inscricao(int numero, String inscricao, String estado)
        {
            this.numero = numero;
            this.inscricao = (TipoInscricao)Enum.Parse(typeof(TipoInscricao), inscricao);
            this.estado = (Estado)Enum.Parse(typeof(Estado), estado);
        }

        public int getNumero()
        {
            return numero;
        }

        public TipoInscricao getTipoInscricao()
        {
            return inscricao;
        }

        public Estado getEstado()
        {
            return estado;
        }

    }
}
