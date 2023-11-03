using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    public GameObject painelCreditos;

    public void BackToStart() {
        SceneManager.LoadScene("MenuScene");
    }
}
