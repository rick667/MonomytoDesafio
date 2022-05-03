using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        GameGenericsProperties.gameStatus = 1;
        SceneManager.LoadScene("Game");
    }
}
