﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueContinue : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            NextSentence();
        }
	}

    public void NextSentence() {
        FindObjectOfType<DialogueManager>().NextSentence();
    }
}
