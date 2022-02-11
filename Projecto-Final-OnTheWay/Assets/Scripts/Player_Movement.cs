using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float speedRotation = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerAxis();
        RotatePlayerAxis();
    }
    private void MovePlayerAxis()
    {
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(speed * new Vector3(0,0,vAxis) * Time.deltaTime);
    }
    private void RotatePlayerAxis()
    {
        //Rotacion en el eje Y
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * hAxis * speedRotation * Time.deltaTime);
    }
}
