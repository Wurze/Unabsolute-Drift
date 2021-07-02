using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LoadPlayer : MonoBehaviour
{
    public GameObject vehiclePrefab;
    public Transform spawPointPlayer;



    // Start is called before the first frame update
    void Start()
    {

        PlayerInput.Instantiate(vehiclePrefab, controlScheme: "Keyboard", pairWithDevice: Keyboard.current);
    }

}
