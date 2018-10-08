using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameObject modalWindow;

    public void SetModal(GameObject newModalWindow)
    {
        modalWindow = newModalWindow;
    }

    public void OpenModal()
    {
        modalWindow.SetActive(true);
        var inputfileds = modalWindow.GetComponentsInChildren<InputField>();
        foreach (InputField input in inputfileds)
        {
            input.text = "";
        }
    }

    public void CloseModal()
    {
        modalWindow.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}