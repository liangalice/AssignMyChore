using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setToText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text getText;
    [SerializeField] Text boxText;
     string[] daysOfWeek;
    string[] names;

    //[SerializeField] Text[] grabText;
    void Start()
    {
        daysOfWeek = new string[7];
        daysOfWeek[0] = "Sunday";
        daysOfWeek[1] = "Monday";
        daysOfWeek[2] = "Tuesday";
        daysOfWeek[3] = "Wednesday";
        daysOfWeek[4] = "Thursday";
        daysOfWeek[5] = "Friday";
        daysOfWeek[6] = "Saturday";

        names = new string[5];
        names[0] = PlayerPrefs.GetString("name1");
        names[1] = PlayerPrefs.GetString("name2");
        names[2] = PlayerPrefs.GetString("name3");
        names[3] = PlayerPrefs.GetString("name4");
        names[4] = PlayerPrefs.GetString("name5");

        GameObject whole = (GameObject)Instantiate(Resources.Load("weekWithTextUse"));
        whole.transform.SetParent(GameObject.FindWithTag("aCanvas").transform, false);
        whole.transform.position = new Vector3(330, 1200, 0);
  
    }
    public void clickToSetText()
    {
      
        int randomDay = Random.Range(0, 7);
        int randomPerson = Random.Range(0, PlayerPrefs.GetInt("numberOfPlayers"));
        string person = names[randomPerson];
        getText.text = names[randomPerson]+" is going to do dishes on " +daysOfWeek[randomDay];
            if(randomDay == 0)
        {
            //sunday
            GameObject.Find("Image").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 1)
        {
            //monday
            GameObject.Find("Image2").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 2)
        {
            //tuesday
            GameObject.Find("Image3").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 3)
        {
            //wednesday
            GameObject.Find("Image4").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 4)
        {
            //thursday
            GameObject.Find("Image5").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 5)
        {
            //friday
            GameObject.Find("Image6").GetComponentInChildren<Text>().text = person;
        }
        if (randomDay == 6)
        {
            //saturday
            GameObject.Find("Image7").GetComponentInChildren<Text>().text = person;
        }
    }
}
