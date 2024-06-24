using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class VRInputManager : MonoBehaviour
{
    private void Update()
    {
        // Überprüfen, ob ConversationManager vorhanden und eine Konversation aktiv ist
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            // Überprüfen, ob der A-Knopf (Button A) des Controllers gedrückt wurde
            if (Input.GetButtonDown("ButtonA"))
            {
                // Die nächste Antwortoption auswählen
                ConversationManager.Instance.SelectNextOption();
            }

            // Überprüfen, ob der B-Knopf (Button B) des Controllers gedrückt wurde
            if (Input.GetButtonDown("ButtonB"))
            {
                // Die vorherige Antwortoption auswählen
                ConversationManager.Instance.SelectPreviousOption();
            }
        }
    }
}