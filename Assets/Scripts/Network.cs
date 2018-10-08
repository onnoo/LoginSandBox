using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class Network : MonoBehaviour
{
    public static Network instance;
    private List<IMultipartFormSection> form;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        form = new List<IMultipartFormSection>();
    }

    public void AddFormElement(string key, string value)
    {
        form.Add(new MultipartFormDataSection(key, value));
    }

    public void SendPost()
    {
        StartCoroutine(PostNetworking());
    }

    public void ClearForm()
    {
        form.Clear();
    }

    IEnumerator PostNetworking()
    {
        UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/", form);
        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            string result = www.downloadHandler.text;
            Debug.Log(result);
            ClearForm();
        }
    }
}
