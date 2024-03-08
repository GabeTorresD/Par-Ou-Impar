using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParOuImpar : MonoBehaviour
{
    public Text nome;
    // o que o jogador digitar
    public InputField input_jogador1;
    // escolha do jogador (se vai ser par ou impar)
    public Text parOuImpar;
    //numero randomico que ser� atribuido ao jogador 2 (m�quina)
    public Text input_jogador2;
    //texto que define quem venceu no par ou impar
    public Text textoVencedor;
    
    

    
    public string escolhaParOuImpar;


    public void imparPar()
    {
        // transforma o input digitado de texto para int 
        int numeroAleatorio = Random.Range(0, 6);
        input_jogador2.text = numeroAleatorio.ToString();
        escolhaParOuImpar = parOuImpar.text;
        int somaTotal = int.Parse(input_jogador1.text) + numeroAleatorio;

        

        if (somaTotal % 2 == 0 && escolhaParOuImpar == "par")
        {
            textoVencedor.text = "O vencedor �: " + nome.text;
        }
        if (somaTotal % 2 == 1 && escolhaParOuImpar == "impar")
        {
            textoVencedor.text = "O vencedor �: " + nome.text;
        }
        if (somaTotal % 2 == 0 && escolhaParOuImpar == "impar")
        {
            textoVencedor.text = "O vencedor � o Jogador 2! ";
        }
        if (somaTotal % 2 == 1 && escolhaParOuImpar == "par")
        {
            textoVencedor.text = "O vencedor � o Jogador 2! ";
        }
   
    }
    
}

