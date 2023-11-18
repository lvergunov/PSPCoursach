using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SinglePlayer : MonoBehaviour
{
    public Dictionary<string, PlayableCharacter> characterPrefabs;
    public Camera cam;
    public PlayableCharacter PlayableCharacter { get { return _character; } }
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void ApplyCharacter(string keyName) {
        _character = Instantiate(characterPrefabs[keyName].transform).GetComponent<PlayableCharacter>();
    }
    private PlayableCharacter _character;
}
