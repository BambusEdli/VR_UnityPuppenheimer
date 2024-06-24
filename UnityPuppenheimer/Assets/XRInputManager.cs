using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.InputSystem;

public class XRInputManager : MonoBehaviour
{
    public Transform controllerTransform; // Die Transform-Komponente des XR-Controllers
    public float maxDistance = 10f; // Die maximale Entfernung für den Raycast
    public LayerMask uiLayerMask; // Die Layer-Maske für die UI-Elemente
    public InputActionReference selectAction; // Die ausgewählte Input-Action für die Auswahl

    private void Update()
    {
        if (ConversationManager.Instance != null)
        {
            if (ConversationManager.Instance.IsConversationActive)
            {
                // Fügen Sie hier die Logik hinzu, um auf die Eingaben der XR-Controller zu reagieren
                // Verwenden Sie beispielsweise Raycasting, um zu bestimmen, auf welches UI-Element (Antwortmöglichkeit) der Spieler zeigt
                // und dann prüfen, ob der Spieler die ausgewählte Eingabe für die Auswahl drückt.

                // Ein Beispiel für Raycasting auf ein UI-Element:
                RaycastHit hit;
                if (Physics.Raycast(controllerTransform.position, controllerTransform.forward, out hit, maxDistance, uiLayerMask))
                {
                    if (hit.collider.gameObject.CompareTag("UIOption"))
                    {
                        Debug.Log("UIOption hit: " + hit.collider.gameObject.name);
                        // Wenn der Spieler die ausgewählte Eingabe drückt, wählen Sie die Antwortmöglichkeit aus
                        if (selectAction.action.triggered) // Hier wird die ausgewählte Input-Action für die Auswahl überprüft
                        {
                            Debug.Log("SelectAction triggered!");
                            hit.collider.gameObject.GetComponent<UIConversationButton>().OnButtonPressed();
                        }
                    }
                }
            }
        }
    }
}

