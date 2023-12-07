﻿

using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas,  int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValid(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna <0 || pos.coluna >= colunas) return false;
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValid(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }

    }
}