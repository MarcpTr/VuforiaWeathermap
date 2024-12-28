using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using TMPro;
using UnityEngine.UI;
public class OpenWeather : MonoBehaviour
{
    public string lat, lon;
    string apikey = "";
    public string description, icon;
    public float temp, windSpeed, windDeg;
    public TMP_Text text;
    public Image image;
    public Sprite sprite;
    public GameObject windArrow;
    void Start()
    { 
       
        StartCoroutine(GetText());
    }
    
    IEnumerator GetText()
    { 
        string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&lang=sp&appid={apikey}";
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
        
        if(www.result!= UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            
            string json= www.downloadHandler.text;
            SimpleJSON.JSONNode data = SimpleJSON.JSON.Parse(json);
            description = data["weather"][0]["description"];
            icon = data["weather"][0]["icon"];
            temp = data["main"]["temp"];
            windSpeed = data["wind"]["speed"];
            windDeg = data["wind"]["deg"];
            text.text=description+ "\u000a" + temp+"º";
            sprite = Resources.Load<Sprite>("Images/" + icon);
            image.sprite = sprite;
            windArrow.transform.localRotation= Quaternion.Euler(0, 0, windDeg);
        }
    }
}
