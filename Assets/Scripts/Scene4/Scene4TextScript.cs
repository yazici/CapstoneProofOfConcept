﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene4TextScript : MonoBehaviour {

    public int enterCount = 0;

    public GameObject spawnDice;
    public GameObject correctDice;

    Vector3 myPos; 

    public GameObject[] biddingDice;

    public bool madeBid = false;

    // Use this for initialization
    void Start () {
        myPos = new Vector3(GameObject.Find("teacup").GetComponent<Transform>().position.x, GameObject.Find("teacup").GetComponent<Transform>().position.y + 1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Return)){   
            enterCount++;
            if (enterCount == 1){
                Scene4Pulse.instance.IncreaseStep();
                this.GetComponent<Text>().text = "And these are my dice.";
                GameObject.Find("MyDiceBoarder").SetActive(false);
                GameObject.Find("EnemyDiceBoarder").GetComponent<SpriteRenderer>().enabled = true;;
            } else if (enterCount == 2){
                Scene4Pulse.instance.IncreaseStep();
                this.GetComponent<Text>().text = "How many 2s are there between our 10 dice? Use the bidding area to make a bid.";
                GameObject.Find ("EnterButton").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("EnemyDiceBoarder").SetActive(false);
                GameObject.Find("BiddingAreaBoarder").GetComponent<SpriteRenderer>().enabled = true;;
                GameObject.Find("BidButtonBoarder").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("1DiceGen").GetComponent<SpriteRenderer>().color = Color.gray;
                GameObject.Find("6DiceGen").GetComponent<SpriteRenderer>().color = Color.gray;
                GameObject.Find("3DiceGen").GetComponent<SpriteRenderer>().color = Color.gray;
                GameObject.Find("4DiceGen").GetComponent<SpriteRenderer>().color = Color.gray;
                GameObject.Find("5DiceGen").GetComponent<SpriteRenderer>().color = Color.gray;
            }
            else if (enterCount == 3 && madeBid){
                //GameObject.Find("BidButton").SetActive(false);
                this.GetComponent<Text>().text = "And another incorrect bid.";
                GameObject.Find("IncorrectText").GetComponent<Text>().enabled = true;
                StartCoroutine(OpenFist());
                biddingDice = GameObject.FindGameObjectsWithTag("BiddingDice");
                foreach (GameObject b in biddingDice){
                    Destroy(b);
                }
                Instantiate(spawnDice, myPos, Quaternion.identity);
                Instantiate(spawnDice, myPos, Quaternion.identity);
            } else if (enterCount == 3 && !madeBid)
            {
                enterCount--;
            }
            else if (enterCount == 4){
                biddingDice = GameObject.FindGameObjectsWithTag("BiddingDice");
                foreach (GameObject b in biddingDice) {
                    Destroy(b);
                }
                this.GetComponent<Text>().text = "Now this would be a correct bid:";
                //GameObject.Find("CurrentBid1").SetActive(false);
                //GameObject.Find("CurrentBid2").SetActive(false);
                StartCoroutine(OpenFist());
                Instantiate(correctDice, myPos, Quaternion.identity);
                Instantiate(correctDice, myPos, Quaternion.identity);
            } else if (enterCount == 5){
                biddingDice = GameObject.FindGameObjectsWithTag("BiddingDice");
                foreach (GameObject b in biddingDice) {
                    Destroy(b);
                }
                this.GetComponent<Text>().text = "You also have the ability to call the opponent if their bid doesn’t match up to the total dice. So try calling this bid:";
                GameObject.Find("CallButton").GetComponent<Image>().enabled = true;
                Scene4Pulse.instance.IncreaseStep();
                Instantiate(correctDice, myPos, Quaternion.identity);
                Instantiate(correctDice, myPos, Quaternion.identity);
                Instantiate(correctDice, myPos, Quaternion.identity);
                Instantiate(correctDice, myPos, Quaternion.identity);
                GameObject.Find ("EnterButton").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find ("CallButtonBoarder").GetComponent<SpriteRenderer>().enabled = true;
            }

        }
	}

    public IEnumerator OpenFist(){
        GameObject.Find("BiddingFist").GetComponent<Scene4HandScript>().myNumber = 1;
        yield return new WaitForSeconds (1f);
        GameObject.Find ("BiddingFist").GetComponent<Scene4HandScript>().myNumber = 0;
    }
}
