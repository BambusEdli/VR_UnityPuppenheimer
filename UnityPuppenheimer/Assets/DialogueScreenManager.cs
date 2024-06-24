using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueScreenManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 1;
    public GameObject dialogueScreen;
    public InputActionProperty showButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Erstzen: soll beim Start des Dialoges ausgeführt werden
        if(showButton.action.WasPressedThisFrame())
        {
            dialogueScreen.SetActive(!dialogueScreen.activeSelf);

            dialogueScreen.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        dialogueScreen.transform.LookAt(new Vector3(head.position.x, dialogueScreen.transform.position.y, head.position.z));
        dialogueScreen.transform.forward *= -1;
    }
}
