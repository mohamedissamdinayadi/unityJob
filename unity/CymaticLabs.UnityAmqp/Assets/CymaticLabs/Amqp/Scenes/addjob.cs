using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.Networking;
 

public class addjob : MonoBehaviour {


    public void addJob2()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {

        UnityWebRequest www = UnityWebRequest.Get("http://192.168.1.115:8080/job?exchange=jsa.exchange&routingKey=jsa.routingkey.add&id=4&name=test5&groupe=test5");
        yield return www.SendWebRequest();

    }





     
}
