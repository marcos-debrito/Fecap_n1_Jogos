using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    public GameObject painelCreditos;

    public void Start()
    {
        //Para destravar o mouse, devido a configuração de outro script.
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void BackToStart() {
        SceneManager.LoadScene("MenuScene");
    }
}
