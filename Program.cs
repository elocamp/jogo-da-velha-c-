using System;
using JogoDaVelha.models;

class Program {
    static void Main() {
        Matriz matriz = new Matriz();
        matriz.preencherMatriz();
        matriz.mostrarMatriz();

        bool menu = true;
        while (menu) {
            int linha = 0;
            int coluna = 0;

            for (int i = 0; i < 8; i++) {

                if (i % 2 == 0) {
                    Console.WriteLine("\nInsira a linha que você deseja inserir o X: \n");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsira a coluna que você deseja inserir o X: \n");
                    coluna = int.Parse(Console.ReadLine());

                    if (matriz.posicaoVazia(linha, coluna)) matriz.inserirX(linha, coluna);
                    else {
                        Console.WriteLine("A posição já está ocupada. Selecione outra posição.");
                        i--;
                    }

                    if (matriz.xGanhou()) {
                        System.Console.WriteLine("\nX venceu o jogo!");
                        menu = false;
                        break;
                    }
                    
                } else {
                    Console.WriteLine("\nInsira a linha que você deseja inserir o O: \n");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsira a coluna que você deseja inserir o O: \n");
                    coluna = int.Parse(Console.ReadLine());

                    if (matriz.posicaoVazia(linha, coluna)) matriz.inserirO(linha, coluna);
                    else {
                        Console.WriteLine("A posição já está ocupada. Selecione outra posição.");
                        i--;
                    }

                    if (matriz.oGanhou()) {
                        System.Console.WriteLine("\nO venceu o jogo!");
                        menu = false;
                        break;
                    }
                }
                matriz.mostrarMatriz();
            }
        }
    }
}