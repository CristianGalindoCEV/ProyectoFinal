using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bauculo : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> vfx = new List<GameObject>();
    public Hand hand;

    public GameObject effecttospawn;

   
    void Start()
    {
        effecttospawn = vfx[0];
    }

    void Update()
    {
        
    }

    public void SpawnVFX()
    {
        GameObject vfx;

        if (firepoint != null)
        {
            vfx = Instantiate(effecttospawn, firepoint.transform.position, Quaternion.identity);
            if (hand != null)
            {
                vfx.transform.localRotation = hand.GetRotation();
            }
        }
        else
        {
            Debug.Log("No FIre Point");
        }
    }

}
