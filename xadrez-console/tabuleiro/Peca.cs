﻿namespace tabuleiro
{
    abstract class Peca
    { 
        public Posicao posicao { get; set; }
        public int qtdMovimentos { get; set; }
        public Cor cor { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();
        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
     
    }
}
