using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class APIHandler : MonoBehaviour {
    
    string _authLink = "https://api.instagram.com/oauth/authorize/?client_id=9fc1ce590f154fb7a361cd446ceda74e"+"&redirect_uri=REDIRECT-URI&response_type=code";
    string self = "https://api.instagram.com/v1/users/self/?access_token=";

    string access_token = "282628530.9fc1ce5.edb208528cd546de91233993ea0f3641";
     public string text;

    private void Start ()
    {
        StartCoroutine (Auth());
    }

    IEnumerator Auth ()
    {
        WWWForm form = new WWWForm ();
        Dictionary<string, string> headers = form.headers;
        
        Debug.Log ("No shit!");
        using (UnityWebRequest www = new UnityWebRequest (self+access_token))
        {
            text = (www.downloadHandler.text);
            if (www.isDone)
            {
                Debug.Log (www.downloadHandler.text);
            }
            yield return new WaitForEndOfFrame ();
        }
    }
}
