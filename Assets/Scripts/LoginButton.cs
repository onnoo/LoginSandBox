using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour
{
    public InputField userID;
    public InputField userPassword;
    // Use this for initialization
    void Start()
    {
        userID.text = "";
        userPassword.text = "";
    }

    public void Onclick()
    {
        Network.instance.AddFormElement("userID", userID.text);
        Network.instance.AddFormElement("userPassword", userPassword.text);
        Network.instance.SendPost();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
