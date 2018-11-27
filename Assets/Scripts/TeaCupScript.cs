﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaCupScript : MonoBehaviour {

	public int myNumber = 0;
	public bool haveHit = false;
	public bool destroyOthers = false;
	bool startCoroutine = false;
    GameObject[] myDice;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (destroyOthers && !startCoroutine) {
			startCoroutine = true;
			StartCoroutine (destroy ());
		}
        if (destroyOthers)
        {
            myDice = GameObject.FindGameObjectsWithTag("BiddingDice");
            foreach (GameObject m in myDice)
            {
                m.transform.position = new Vector3 (7.01f, 4.01f, 0);
               // Destroy(m);
            }
            destroyOthers = false;
            //  Destroy (col.gameObject);
            //  col.gameObject.SetActive (false);
        }
    }

	void OnCollisionEnter2D (Collision2D col){
        GameObject.Find ("CurrentBidSlot").GetComponent<CurrentBidSlotScript>().shouldDestroy = true;

        if (!destroyOthers) {
            GameObject.Find ("CurrentBidSlot").GetComponent<CurrentBidSlotScript>().shouldDestroy = true;
			if (col.gameObject.name == "1Dice 1(Clone)" && !haveHit) {
				myNumber = 1;
				haveHit = true;
			} else if (col.gameObject.name == "2Dice 1(Clone)" && !haveHit) {
				myNumber = 2;
				haveHit = true;
			} else if (col.gameObject.name == "3Dice 1(Clone)" && !haveHit) {
				myNumber = 3;
				haveHit = true;
			} else if (col.gameObject.name == "4Dice 1(Clone)" && !haveHit) {
				myNumber = 4;
				haveHit = true;
			} else if (col.gameObject.name == "5Dice 1(Clone)" && !haveHit) {
				myNumber = 5;
				haveHit = true;
			} else if (col.gameObject.name == "6Dice 1(Clone)" && !haveHit) {
				myNumber = 6;
				haveHit = true;
			}
		}
	}

	void OnCollisionStay2D (Collision2D col){
	//	Debug.Log (col.gameObject.name);
		if (destroyOthers) {
            myDice = GameObject.FindGameObjectsWithTag("BiddingDice");
            foreach (GameObject m in myDice){
                m.transform.position = new Vector3 (7.01f, 4.01f, 0);
                //Destroy (m);
            }
		//	Destroy (col.gameObject);
		//	col.gameObject.SetActive (false);
		}
	}

	IEnumerator destroy(){
		yield return new WaitForSeconds (2f);
		destroyOthers = false;
		startCoroutine = false;
		haveHit = false;
        myNumber = 0;
	}

}