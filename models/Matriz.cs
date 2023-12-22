using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDaVelha.models {
    public class Matriz {
        public char[,] matriz = new char[3,3];
        
        public void preencherMatriz() {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = ' ';
                }
            }
        }

        public void mostrarMatriz() {
            string saida = "";
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.Length; j++) {
                    saida += "[" + matriz[i, j] + "]";
                }
                System.Console.WriteLine(saida);
                saida = "";
            }
        }

        public bool posicaoVazia(int linha, int coluna) {
            return matriz[linha, coluna] == ' ';
        }

        public void inserirX(int linha, int coluna) {
            matriz[linha, coluna] = 'X';
        }

        public void inserirO(int linha, int coluna) {
            matriz[linha, coluna] = 'O';
        }

        public bool xGanhou() {
            if (
                (matriz[0,0] == 'X' && matriz[0,1] == 'X' && matriz[0,2] == 'X') ||
                (matriz[1,0] == 'X' && matriz[1,1] == 'X' && matriz[1,2] == 'X') ||
                (matriz[2,0] == 'X' && matriz[2,1] == 'X' && matriz[2,2] == 'X') ||
                (matriz[0,0] == 'X' && matriz[1,0] == 'X' && matriz[2,0] == 'X') ||
                (matriz[0,1] == 'X' && matriz[1,1] == 'X' && matriz[2,1] == 'X') ||
                (matriz[0,2] == 'X' && matriz[1,2] == 'X' && matriz[2,2] == 'X') ||
                (matriz[0,0] == 'X' && matriz[1,1] == 'X' && matriz[2,2] == 'X') ||
                (matriz[0,2] == 'X' && matriz[1,1] == 'X' && matriz[2,0] == 'X')
            ) {
                return true;
            }
            return false;
        }

        public bool oGanhou() {
            if (
                (matriz[0,0] == 'O' && matriz[0,1] == 'O' && matriz[0,2] == 'O') ||
                (matriz[1,0] == 'O' && matriz[1,1] == 'O' && matriz[1,2] == 'O') ||
                (matriz[2,0] == 'O' && matriz[2,1] == 'O' && matriz[2,2] == 'O') ||
                (matriz[0,0] == 'O' && matriz[1,0] == 'O' && matriz[2,0] == 'O') ||
                (matriz[0,1] == 'O' && matriz[1,1] == 'O' && matriz[2,1] == 'O') ||
                (matriz[0,2] == 'O' && matriz[1,2] == 'O' && matriz[2,2] == 'O') ||
                (matriz[0,0] == 'O' && matriz[1,1] == 'O' && matriz[2,2] == 'O') ||
                (matriz[0,2] == 'O' && matriz[1,1] == 'O' && matriz[2,0] == 'O')
            ) {
                return true;
            }
            return false;
    }
    }
}