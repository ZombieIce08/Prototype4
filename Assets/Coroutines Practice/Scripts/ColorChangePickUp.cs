using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChangePickUp : MonoBehaviour
{
    [Header("Materials")]
    public Material defaultMaterial;
    public Material newMaterial;

    [Header("Duration")]
    public float duration;

    //Components

    private MeshRenderer myMr;
    private MeshRenderer playerMr;
    private Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myMr = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag ("Player"))
        {
            //Get PlayerMr
            playerMr = other.gameObject.GetComponent<MeshRenderer>();

            //Actitvate the coroutine
            StartCoroutine(ChangeColor());
        }

    }

    IEnumerator ChangeColor()
    {
        //Change Color 
        playerMr.material = newMaterial;
        

        //Wait
        yield return new WaitForSeconds(duration);

        //Change Color Back
        playerMr.material = defaultMaterial;
    }

   
        
    }

