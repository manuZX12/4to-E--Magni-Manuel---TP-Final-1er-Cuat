using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    CharacterController characterController;
    [Header("Opciones de personaje")]
    public float walkSpeed = 6.0f;
    public float runSpeed = 10.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    [Header("Opciones de camara")]
    public Camera cam;
    public float mouseHorizontal = 3.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    float h_mouse, v_mouse;

    [Header("Player With GAME")]
    public GameObject FirstGame;
    float WalkBackup;
    float JumpBackup;
    float mouseHorizontalBackUp = 3.0f;
    float mouseVerticalBackup = 2.0f;
    private Vector3 move = Vector3.zero;

    [Header("Sound Clips")]
    public AudioSource source;
    public AudioClip Pasos;
    public AudioClip Salto;
    public AudioClip ObjetivoLogrado;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;

        WalkBackup = walkSpeed;
        JumpBackup = jumpSpeed;
        mouseHorizontalBackUp = mouseHorizontal;
        mouseVerticalBackup = mouseVertical;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            PlayClip();
        }
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y");

        v_mouse = Mathf.Clamp(v_mouse, minRotation, maxRotation);


        cam.transform.localEulerAngles = new Vector3(-v_mouse, 0, 0);

        transform.Rotate(0, h_mouse, 0);


        if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            PlayClip();
            if (Input.GetKey(KeyCode.LeftShift))
            { 
                move = transform.TransformDirection(move) * runSpeed;
            }
         else
            {
                move = transform.TransformDirection(move) * walkSpeed;
                PlayClip();
            }
                

            if (Input.GetKey(KeyCode.Space))
            {
                move.y = jumpSpeed;
            }


        }
        move.y -= gravity * Time.deltaTime;

        characterController.Move(move * Time.deltaTime);

        if(FirstGame.transform.localEulerAngles.x == 0)
        {
            walkSpeed = 0;
            jumpSpeed = 0;
            mouseHorizontal = 0f;
            mouseVertical = 0f;
        }
        else
        {
            walkSpeed = WalkBackup;
            jumpSpeed = JumpBackup;
            mouseHorizontal = mouseHorizontalBackUp;
            mouseVertical = mouseVerticalBackup;
        }
        
       void PlayClip()
        {
            source.clip = Pasos;
            source.Play();
        }
        
    }
    
}

