using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToCorrectPlayers : MonoBehaviour
{
    [SerializeField] Text getPlayers;
    // Start is called before the first frame update
   public void changeToCorrectPlayer()
    {
        PlayerPrefs.SetInt("numberOfPlayers", int.Parse(getPlayers.text));
        if (getPlayers.text.Equals("2"))
        {
            SceneManager.LoadScene("SecondScene");
        }
        if (getPlayers.text.Equals("3"))
        {
            SceneManager.LoadScene("ThirdScene");
        }
        if (getPlayers.text.Equals("4"))
        {
            SceneManager.LoadScene("FourthScene");
        }
        if (getPlayers.text.Equals("5"))
        {
            SceneManager.LoadScene("FifthScene");
        }
    }
}
