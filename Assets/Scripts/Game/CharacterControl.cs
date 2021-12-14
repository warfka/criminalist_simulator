using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 4.0f; //скорость персонажа
    public float jumpSpeed = 8.0f; //скорость прыжка персонажа 
    public float gravity = 20.0f;  //переменная гравитации персонажа
    private Vector3 moveDir = Vector3.zero; //переменная движения персонажа
    private CharacterController controller; //переменная содержущая компонент CharacterController


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame !! в FixedUpdate движение определяется не по кадрам, а по истечению времени (персонаж двигается хорошо)
    void Update()
    {
        if(controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }
        if(Input.GetKeyUp(KeyCode.Space) && controller.isGrounded)
        {
            moveDir.y = jumpSpeed;
        }


        moveDir.y -= gravity * Time.deltaTime;

        controller.Move(moveDir * Time.deltaTime);
    }
}
