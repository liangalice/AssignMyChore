using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setNameTo_ : MonoBehaviour
{
    [SerializeField] Text name1;
    [SerializeField] Text name2;
    [SerializeField] Text name3;
    [SerializeField] Text name4;
    [SerializeField] Text name5;
    public void setName()
    {
        PlayerPrefs.SetString("name1", name1.text);
        PlayerPrefs.SetString("name2", name2.text);
        PlayerPrefs.SetString("name3", name3.text);
        PlayerPrefs.SetString("name4", name4.text);
        PlayerPrefs.SetString("name5", name5.text);

   //     Debug.Log(PlayerPrefs.GetString("name1"));
   //     Debug.Log(PlayerPrefs.GetString("name2"));
   //     Debug.Log(PlayerPrefs.GetString("name3"));
     //   Debug.Log(PlayerPrefs.GetString("name4"));
     //   Debug.Log(PlayerPrefs.GetString("name5"));
    }
}
