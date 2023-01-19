using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PathCreation;

public class Man : MonoBehaviour
{
    public AudioSource comeAndGet;
    public GameObject button1,button2, pathCreatorG;
    public Animator _anim;
    public PathCreator pathCreator;
    public float speed = 2f;
    float distanceTravelled;

    private void Start()
    {
        
    }

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            speed = 0;
            _anim.SetTrigger("Idle");
            button1.SetActive(true);
            button2.SetActive(true);
            comeAndGet.Play();
            pathCreatorG.SetActive(true);
        }

    }

   
}
