using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    public GameObject explosionprefab;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.CompareTag("Player"))
        {

            KillObject();
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject, .1f);

    }

    public void KillObject()
    {
        Destroy(gameObject, .1f);

        Instantiate(explosionprefab, gameObject.transform.position, Quaternion.identity);

    }

}
