﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {

    public GameObject dice1;
    public GameObject dice2;
    public GameObject dice3;
    public GameObject dice4;
    public GameObject dice5;
    public GameObject dice6;
    public GameObject screenBorders;
    public GameObject[] transitionDice;
    float a = 0;
    public int carryOverDice;
    float color = 255;
    public Sprite testBG;
    Vector2 spawnPos;
    float changeVar;
    float changeVarY;
    public int sceneChangeNumb = 0;
    public string[] sceneNames;

    // Use this for initialization
    void Start() {
        //DontDestroyOnLoad(this.gameObject);
        //DontDestroyOnLoad(GameObject.Find("ScreenBorders"));


        //if (FindObjectOfType<SceneTransitionScript>() != null)
        //{
        //    FindObjectOfType<SceneTransitionScript>().Clear();
        //}
        screenBorders = GameObject.Find("ScreenBorders");
        //if (SceneManager.GetActiveScene().name == sceneNames[0])
        //{
            StartCoroutine(FadeIn());
            //Clear();
            StartCoroutine(BeginScene());
        //}
        //StartCoroutine(FadeToBlack());
    }
    
    // Update is called once per frame
    //void Update () {
        
    //}

    void SpawnDice()
    {
        Time.timeScale = 1.5f;
        for (int i = 0; i < 175; i++)
        {
            int temp = Random.Range(1, 4);
            changeVar = Random.Range(-7.5f, 7.5f);
            changeVarY = Random.Range(-1f + i/10, 15f + i/10);
            spawnPos = new Vector2(transform.position.x + changeVar, transform.position.y + changeVarY);
            if (temp == 1) {
                Instantiate(dice1, spawnPos, Quaternion.identity);
            } else if (temp == 2) {
                Instantiate(dice2, spawnPos, Quaternion.identity);
            }
            else if (temp == 3)
            {
                Instantiate(dice3, spawnPos, Quaternion.identity);
            }
            else if (temp == 4)
            {
                Instantiate(dice4, spawnPos, Quaternion.identity);
            }
            else if (temp == 5)
            {
                Instantiate(dice5, spawnPos, Quaternion.identity);
            }
            else if (temp == 6)
            {
                Instantiate(dice6, spawnPos, Quaternion.identity);
            }
        }
        //screenBorders.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
        //StartCoroutine(FadeToBlack());
    }

    public void Clear() {
        Time.timeScale = 1;
        //what...fix this
        Debug.Log("clear");
        screenBorders.GetComponent<BoxCollider2D>().enabled = false;
    }

    public IEnumerator BeginScene()
    {
        Debug.Log("begin scene");
        screenBorders.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(4f);
        Debug.Log("collider on");
        Time.timeScale = 1;
        screenBorders.GetComponent<BoxCollider2D>().enabled = true;
    }

    public IEnumerator FadeToBlack()
    {
        //screenBorders.GetComponent<ScreenBorders>().player = GameObject.Find("Player");
        //screenBorders.GetComponent<ScreenBorders>().Check();
        a = 0;
        screenBorders.GetComponent<ScreenBorders>().CheckBeforeChange();
        GameObject player = GameObject.Find("Player");
        transform.position = new Vector2(0, player.transform.position.y + 10);
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        SpawnDice();
        yield return new WaitForSeconds(0.4f);
        Debug.Log("my screen borders is " + screenBorders);
        //a += 10;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);
        yield return new WaitForSeconds(0.2f);
        a += 0.2f;
        color -= 25;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);
        yield return new WaitForSeconds(0.2f);
        a += 0.2f;
        color -= 25;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);
        yield return new WaitForSeconds(0.2f);
        a += 0.2f;
        color -= 25;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);
        yield return new WaitForSeconds(0.2f);
        a += 0.2f;
        color -= 25;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);

        yield return new WaitForSeconds(0.2f);
        a += 0.2f;
        color -= 25;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        Debug.Log("my a value is: " + a);
        yield return new WaitForSeconds(0.2f);
        //Time.timeScale = 2;
        yield return new WaitForSeconds(2f);
        Camera.main.enabled = false;
        //GL.Clear(true, true, Color.black);
        //start another coroutine
        Debug.Log("go");
        transitionDice = GameObject.FindGameObjectsWithTag("TransitionDice");

        foreach (GameObject dice in transitionDice)
        {
            dice.GetComponent<TransitionDiceScript>().CheckBG();
        }
        //Clear();
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneNames[sceneChangeNumb]);
        //foreach (GameObject dice in transitionDice)
        //{
        //    dice.GetComponent<TransitionDiceScript>().Check();
        //}
        screenBorders = GameObject.Find("ScreenBorders");
        screenBorders.GetComponent<ScreenBorders>().Check();
        Debug.Log("fade in");
        //yield return new WaitForSeconds(0.5f);

        //StartCoroutine(FadeIn());

        //screenBorders.GetComponent<SpriteRenderer>().sprite = testBG;
        //screenBorders.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
    }


    IEnumerator FadeIn()
    {
        a = 1;
        Debug.Log("in");
        screenBorders = GameObject.Find("ScreenBorders");
        transitionDice = GameObject.FindGameObjectsWithTag("TransitionDice");
        foreach (GameObject d in transitionDice)
        {
            d.transform.position = new Vector3(d.transform.position.x + screenBorders.transform.position.x, d.transform.position.y + screenBorders.transform.position.y, 0);
        }
        a -= 0.2f;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        yield return new WaitForSeconds(0.15f);
        a -= 0.2f;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        yield return new WaitForSeconds(0.15f);
        a -= 0.2f;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        yield return new WaitForSeconds(0.15f);
        a -= 0.2f;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        yield return new WaitForSeconds(0.15f);
        a -= 0.2f;
        screenBorders.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, a);
        if (SceneManager.GetActiveScene().name == "BattleSceneNew")
        {
            GameObject.Find("BattleManager").GetComponent<BattleManager>().BeginBattlePlz();
        }
        yield return new WaitForSeconds(2f);
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;

        //yield return new WaitForSeconds(4f);
        //Destroy(screenBorders);
        //Destroy(this.gameObject);
        yield return new WaitForSeconds(5f);
        transitionDice = GameObject.FindGameObjectsWithTag("TransitionDice");
        foreach (GameObject d in transitionDice)
        {
            Destroy(d);
        }
        screenBorders.GetComponent<ScreenBorders>().Check();
    }
}