using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string nomeDoLevelDeJogo;
    public GameObject painelMenuInicial;
    public GameObject painelOpcoes;


    /* Funcao responsável por trocar de cena, para iniciar o jogo */
    public void Jogar() {
        SceneManager.LoadScene("GameScene");
    }

    /* O método SetActive é responsável por ativar e desativar o objeto */
    public void AbrirOpcoes() {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    
    public void fecharOpcoes(){
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }


    public void SairJogo() {
        Debug.Log("Encerrou o jogo");
        Application.Quit();
    }
}
