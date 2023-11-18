using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssassinLogic : PlayableCharacter
{
    private void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        Move();
    }

    protected override void UseSuperability()
    {
        throw new System.NotImplementedException();
    }
}
