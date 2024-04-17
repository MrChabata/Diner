using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class IntroDialogueController : MonoBehaviour
{
    // Start is called before the first frame update
    NPCConversation conversation;
    public CharecterDialogueController cdc;
    void Start()
    {
        conversation = GetComponent<NPCConversation>();
        ConversationManager.Instance.StartConversation(conversation);
        cdc.DisableMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
