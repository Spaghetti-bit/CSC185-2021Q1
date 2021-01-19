using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 100;
    public Material material;

    public AudioSource audioSource;

    public void Start()
    {
        GetComponent<Renderer>().material = material;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            Game.Instance.AddPoints(points);
            audioSource.Play();
            Destroy(transform.parent.gameObject);
        }
    }
}
