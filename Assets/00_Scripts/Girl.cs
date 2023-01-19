using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Girl : MonoBehaviour
{
    private CharacterController _charController;
    Animator _anim;
    private Transform meshChar;
    float speed = 5.0f;
    public AudioSource _whatrudoing;




    void Start()
    {
        _charController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
        meshChar = _charController.transform;
        _anim = meshChar.GetComponent<Animator>();
        speed = 5f;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
            // _anim.SetBool("isWalk", true);
        }
        if (!Input.GetKey(KeyCode.W))
        {
      
            // _anim.SetBool("isWalk", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
           transform.Translate(- Time.deltaTime*speed, 0, 0, Camera.main.transform);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime*speed, 0, 0, Camera.main.transform);
        }
  
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Walll2"))
        {
            _whatrudoing.Play();
        }
    }
}
