using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartUI : MonoBehaviour
{
    public Canvas firstCanvas;
    public Canvas connectingParamsCanvas;
    public GameObject ipInputField;
    public void StartGameAsHost() {
        PlayerPrefs.SetString("UserType", "Server");
        SceneManager.CreateScene("SampleScene");
    }

    public void EnterIntoConnectingField() { 
        firstCanvas.enabled = false;
        connectingParamsCanvas.enabled = true;
    }

    public void ExitToStartMenu() {
        connectingParamsCanvas.enabled = false;
        firstCanvas.enabled = true;
    }

    public void StartGameAsClient()
    {
        string ipAddr = ipInputField.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString("UserType", "Client");
        PlayerPrefs.SetString("ServerIp", ipAddr);
        SceneManager.CreateScene("SampleScene");
    }
}
