using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterDialogueController : MonoBehaviour
{
    FirstPersonAudio fpa;
    FirstPersonMovement fpm;
    Jump jump;
    Crouch crouch;
    FirstPersonLook fpl;
    private float initialSpeed;
    private float initialRunSpeed;
    private float jumpStrength;
    private float movementSpeed;
    private float sensivity;
    // Start is called before the first frame update
    void Start()
    {
        fpa = GetComponentInChildren<FirstPersonAudio>();
        fpm = GetComponent<FirstPersonMovement>();
        jump = GetComponent<Jump>();
        crouch = GetComponent<Crouch>();
        fpl = GetComponentInChildren<FirstPersonLook>();
        initialSpeed = fpm.speed;
        initialRunSpeed = fpm.runSpeed;
        jumpStrength = jump.jumpStrength;
        sensivity = fpl.sensitivity;
        movementSpeed = crouch.movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableMovement()
    {
        fpa.enabled = true;
        crouch.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        fpm.speed = initialSpeed;
        fpm.runSpeed = initialRunSpeed;
        jump.jumpStrength = jumpStrength;
        fpl.sensitivity = sensivity;
    }
   
    public void DisableMovement()
    {
        fpa.stepAudio.Stop();
        fpa.runningAudio.Stop();
        fpa.landingAudio.Stop();
        fpa.crouchStartAudio.Stop();
        fpa.crouchedAudio.Stop();
        fpa.crouchEndAudio.Stop();
        fpa.enabled = false;
        crouch.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        fpm.speed = 0;
        fpm.runSpeed = 0;
        jump.jumpStrength = 0;
        fpl.sensitivity = 0;
    }
}
