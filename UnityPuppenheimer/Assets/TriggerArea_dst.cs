using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{
    // UnityEvent, das im Inspector zugeordnet wird und ausgelöst wird, wenn der Spieler den Trigger betritt
    public UnityEvent OnTriggerEntered;

    private bool inRange = false;
    private bool roomLeft = false;

     private void Update()
    {
        // Wenn der Spieler in Reichweite ist und die Interaktions-Taste gedrückt wird
        if (inRange && !roomLeft)
        {
            endGame();
        }
    }

    // Diese Funktion wird aufgerufen, wenn ein anderes Objekt den Trigger betritt
    private void OnTriggerEnter(Collider other)
    {
        // Überprüfen, ob der Spieler den Aktivierungs-Trigger betritt
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Überprüfen, ob der Spieler den Aktivierungs-Trigger verlässt
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    private void endGame()
    {
        // Löse das UnityEvent aus, das im Inspector zugeordnet wurde
        OnTriggerEntered.Invoke();
    }
}



