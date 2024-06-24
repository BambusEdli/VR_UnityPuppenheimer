using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    // NPCConversation Variable (assigned in Inspector)
    public NPCConversation Conversation;
    public float activationRadius = 3f; // Radius, in dem der Dialog aktiviert wird

    private bool inRange = false;
    private bool convoStarted = false;

    private void Update()
    {
        // Wenn der Spieler in Reichweite ist und die Interaktions-Taste gedrückt wird
        if (inRange && !convoStarted)
        {
            startConvo();
        }
    }

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

    public void startConvo()
    {
        ConversationManager.Instance.StartConversation(Conversation);
        convoStarted = true;
    }
}