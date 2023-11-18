using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBuild : MonoBehaviour
{
    public SinglePlayer playerContainer;
    void Awake()
    {
        string programType = PlayerPrefs.GetString("UserType");
        if (programType.Equals("Server"))
            ModeleAsMainHost();
    }

    void Update()
    {
        
    }

    private void ModeleAsMainHost() {
        playerContainer.ApplyCharacter("assassin");
    }
}
