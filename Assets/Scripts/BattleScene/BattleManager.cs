﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

    public int myDice;
    public int enemyDice;
    public List<int> myCurrentDice;
    public List<int> enemyCurrentDice;
    public int currentBidNumber;
    public int currentBidAmount;
    int actualAmount;
    public bool myTurn = true;
    public int counter = 0;
    public bool enemyToCall = false;
    bool playerLose = false;
    public int turnCount = 0;

    int enemyType;

    public Dialogue happyDialogue;
    public Dialogue sadDialogue;

    public GameObject[] battleDice;
    public GameObject[] enemyBattleDice;
    public GameObject[] currentBidDice;

    public GameObject spinnyNewDice;

    public Sprite happyMaya;
    public Sprite sadMaya;
    public Sprite normalMaya;

    public Sprite happyEnemy;
    public Sprite sadEnemy;
    public Sprite normalEnemy;

    public Sprite[] blinkSprites;
    float blinkCounter;
    bool isNormalFace = true;
    float blinkSpritesTimer = 0.03f;

    public Transform boxPos;

    bool glitchMe = false;

    public AudioClip happyReaction;
    public AudioClip sadReaction;
    AudioSource myAudio;

    public void BeginBattlePlz()
    {
        Cursor.visible = true;
        StartCoroutine(BeginBattle());
    }
    IEnumerator BeginBattle() {

        //TODO: THESE ARE NOT NECESARILY TRUE // figure out how to get that info
        myDice = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().myDice;
        enemyDice = 5;

        battleDice = GameObject.FindGameObjectsWithTag("Dice");
        enemyBattleDice = GameObject.FindGameObjectsWithTag("EnemyDice");


        //TODO: This naming sucks
        boxPos = GameObject.Find("teacup").GetComponent<Transform>();

        Debug.Log(GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().enemyHit);
        GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().enemyNumber = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().enemyHit;
        Debug.Log(GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().enemyNumber);

        enemyType = GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().enemyNumber;
        if (enemyType == 1)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 0;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.blinkSprites;
        }
        else if (enemyType == 2)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 1;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.blinkSprites;
        }
        else if (enemyType == 3)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 2;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.blinkSprites;
        }
        else if (enemyType == 4)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 3;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Julia.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Julia.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Julia.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Julia.blinkSprites;
        }
        else if (enemyType == 5)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 4;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.blinkSprites;
        }
        else if (enemyType == 6)
        {
            glitchMe = true;
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 5;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.blinkSprites;
        }
        else if (enemyType == 7)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 6;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.blinkSprites;
        }
        else if (enemyType == 8)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 7;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Jacob.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Jacob.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Jacob.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Jacob.blinkSprites;
        }
        else if (enemyType == 9)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 8;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.blinkSprites;
        }
        else if (enemyType == 10)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 9;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.blinkSprites;
        }
        else if (enemyType == 11)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 10;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.blinkSprites;
        }
        else if (enemyType == 12)
        {
            glitchMe = true;
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 11;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Amelia.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Amelia.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Amelia.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Amelia.blinkSprites;
        }
        else if (enemyType == 13)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 12;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai1.blinkSprites;
        }
        else if (enemyType == 14)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 13;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai2.blinkSprites;
        }
        else if (enemyType == 15)
        {
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 14;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Ai3.blinkSprites;
        }
        else if (enemyType == 16)
        {
            glitchMe = true;
            GameObject.Find("DiceMaker").GetComponent<SceneTransitionScript>().sceneChangeNumb = 15;
            normalEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Simon.enemySprites[0];
            happyEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Simon.enemySprites[1];
            sadEnemy = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Simon.enemySprites[2];
            blinkSprites = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().Simon.blinkSprites;
        }

        //GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = GameObject.Find("StatsTracker").GetComponent<PlayerStatsTracker>().enemySprites[enemyType];
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = normalEnemy;
        happyDialogue.speakerSprite = happyEnemy;
        sadDialogue.speakerSprite = sadEnemy;
        myAudio = GetComponent<AudioSource>();
        yield return new WaitForSeconds(0.2f);
        GameObject.Find("RollArrow").GetComponent<RollForPlay>().Spin();
        yield return new WaitForSeconds(5f);
        if (glitchMe)
        {
            StartCoroutine(GameObject.Find("PlayerDice0").GetComponent<GlitchDiceScript>().GlitchMe());
            yield return new WaitForSeconds(2f);
        }
        Roll();
        //yield return new WaitForSeconds(10f);
        //Debug.Log("setactive");
        //GameObject.Find("ScreenBorders").SetActive(true);
    }

    // Update is called once per frame
    //void Update () {

    //}

    private void Update()
    {
        if (isNormalFace)
        {
            blinkCounter += Time.deltaTime;
        }
        if (blinkCounter >= 2.3f)
        {
            blinkCounter = 0;
            StartCoroutine(Blink());
        }
        GameObject.Find("CurrentBidText").GetComponent<CurrentBidText>().ChangeText(currentBidAmount, currentBidNumber);
    }

    IEnumerator Blink()
    {
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[0];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[1];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[2];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[3];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[4];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[5];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[6];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[7];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[8];
        yield return new WaitForSeconds(blinkSpritesTimer);
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = blinkSprites[9];
        yield return new WaitForSeconds(blinkSpritesTimer);

    }

    public void EnemyTurn (){
        GameObject.Find("teacup").GetComponent<TeaCupScript>().destroyOthers = true;
        turnCount++;
        counter = 0;
        for (int i = 0; i < enemyCurrentDice.Count; i++){
            if (enemyCurrentDice[i] == currentBidNumber){
                counter++;
            }
        }
        if (counter > currentBidAmount + 1)
        {
            EnemyCall();
        }
        else if (enemyType == 1)
        {
            GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().Turn();
        }
        else if (enemyType == 2)
        {
            GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().TurnAi2();
        }
        else if (enemyType == 3)
        {
            GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().TurnAi3();
        }
        else if (enemyType == 4)
        {
            GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().TurnJulia();
        }
        //myTurn = true;
        //StartCoroutine(DestroyOpponentFirstBid());
    }

    void Roll () {
        //Debug.Log("ROLLING");

        //TODO: This naming sucks
        GameObject.Find ("teacup").GetComponent<TeaCupScript>().myNumber = 0;
        GameObject.Find("CurrentBidText").GetComponent<CurrentBidText>().ChangeText(0, 0);
        myCurrentDice.Clear();
        enemyCurrentDice.Clear();
        actualAmount = 0;
        battleDice = GameObject.FindGameObjectsWithTag("Dice");
        enemyBattleDice = GameObject.FindGameObjectsWithTag("EnemyDice");
        currentBidDice = GameObject.FindGameObjectsWithTag("BiddingDice");
        foreach (GameObject d in battleDice){
            //TODO: this won't work with special dice right?
            d.GetComponent<BaseDiceScript>().Roll();
        }
        foreach (GameObject e in enemyBattleDice){
           //TODO: gonna have special enemy dice? unlikely but possible
           e.GetComponent<EnemyDiceScript>().Roll();
        }
        foreach (GameObject b in currentBidDice){
            Destroy(b);
        }
        //TODO: necessary?
        //GameObject.Find ("CurrentBidSlot").GetComponent<CurrentBidSlotScript>().shouldDestroy = true;

        //TODO: this stuff useless now?
        for (int i = 0; i < myDice; i++){
            int temp = Random.Range(0, 6);
          //  myCurrentDice.Add(temp);
        }
        for (int j = 0; j < enemyDice; j++){
            int temp = Random.Range(0, 6);
            //enemyCurrentDice.Add(temp);
        }

        //TODO: name sucks
        GameObject.Find("playerPortrait").GetComponent<SpriteRenderer>().sprite = normalMaya;
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = normalEnemy;
        isNormalFace = true;
        blinkCounter = 0f;
        GameObject.Find("teacup").GetComponent<TeaCupScript>().destroyOthers = true;
        GameObject.Find("CurrentBidSlot").GetComponent<CurrentBidSlotScript>().shouldDestroy = true;
        GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().bluffingNumb = 0;
        GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().bluffingNumb2 = 0;
        GameObject.Find("Enemy").GetComponent<BaseAiEnemy>().MayaBids.Clear();
    }

    //This seems perfect
    public void PlayerCall () {
        foreach (GameObject e in enemyBattleDice){
            e.GetComponent<EnemyDiceScript>().shouldShow = true;
        }

        for (int i = 0; i < myCurrentDice.Count; i++){
            if (myCurrentDice[i] == currentBidNumber){
                actualAmount++;
            }
        }
        for (int j = 0; j < enemyCurrentDice.Count; j++){
            if (enemyCurrentDice[j] == currentBidNumber){
                actualAmount++;
            }
        }
        if (actualAmount >= currentBidAmount){
            PlayerLoses();
        } else {
            EnemyLoses();
        }
    }

    public void EnemyCall () {
        foreach (GameObject e in enemyBattleDice) {
            e.GetComponent<EnemyDiceScript>().shouldShow = true;
        }

        for (int i = 0; i < myCurrentDice.Count; i++) {
            if (myCurrentDice[i] == currentBidNumber) {
                actualAmount++;
            }
        }
        for (int j = 0; j < enemyCurrentDice.Count; j++){
            if (enemyCurrentDice[j] == currentBidNumber){
                actualAmount++;
            }
        }

        //TODO: I don't think this should be here. Loser starts?
        //myTurn = true;

        if (actualAmount >= currentBidAmount) {
            EnemyLoses();
        } else {
            PlayerLoses();
        }
    }

    public void EnemyBid (int amount, int number) {

        //TODO: This work should be done in enemy script
        if (number > 6){
            number = 1;
            amount += 1;
        }

        currentBidAmount = amount;
        currentBidNumber = number;
        StartCoroutine(WaitToSwitchTurn());
      //  myTurn = true;
    }

    void PlayerLoses () {
        StopAllCoroutines();
        isNormalFace = false;
        GameObject.Find("playerPortrait").GetComponent<SpriteRenderer>().sprite = sadMaya;
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = happyEnemy;
        playerLose = true;
        myDice--;
        if (myDice <= 0){
            GameOver();
        } else {
            if (enemyType != 4 && enemyType != 8 && enemyType != 12 && enemyType != 16)
            {
                myAudio.PlayOneShot(happyReaction);
            }
            StartCoroutine(PauseForRoll(false));
            FindObjectOfType<DialogueManager>().StartDialogue(happyDialogue);
            StartCoroutine(EndDialogue());
            //Roll();
        }
        myTurn = true;
    }

    void EnemyLoses () {
        StopAllCoroutines();
        isNormalFace = false;
        GameObject.Find("playerPortrait").GetComponent<SpriteRenderer>().sprite = happyMaya;
        GameObject.Find("enemyPortrait").GetComponent<SpriteRenderer>().sprite = sadEnemy;
        enemyDice--;
        if (enemyDice <= 0){

            //TODO: this can be done without GameObject.Find every time
            StartCoroutine(GameObject.Find("Spark").GetComponent<SparkScript>().SparkMe());
            EnemyGameOver();
        } else {

            //TODO: same thing about not doing it with GameObject.Find every time
            if (enemyType != 4 && enemyType != 8 && enemyType != 12 && enemyType != 16)
            {
                myAudio.PlayOneShot(sadReaction);
            }
            StartCoroutine(GameObject.Find("Spark").GetComponent<SparkScript>().SparkMe());
            StartCoroutine(PauseForRoll(true));
            FindObjectOfType<DialogueManager>().StartDialogue(sadDialogue);
            StartCoroutine(EndDialogue());
            //  Roll ();
        }
        myTurn = false;
    }
    IEnumerator DestroyOpponentFirstBid()
    {
        yield return new WaitForSeconds(1f);
        GameObject.Find("teacup").GetComponent<TeaCupScript>().destroyOthers = true;
    }

    IEnumerator WaitToSwitchTurn()
    {
        yield return new WaitForSeconds(0.8f);
        myTurn = true;
    }
    
    IEnumerator PauseForRoll (bool shouldPause) {
        if (shouldPause)
        {
            yield return new WaitForSeconds(3f);
        }
        //Debug.Log("ok clear please");
        myCurrentDice.Clear();
        enemyCurrentDice.Clear();
        actualAmount = 0;
        currentBidAmount = 0;
        currentBidNumber = 0;
        yield return new WaitForSeconds (1f);
        foreach (GameObject e in enemyBattleDice) {
            e.GetComponent<EnemyDiceScript>().shouldShow = false;
        }

        yield return new WaitForSeconds (0.5f);

        //TODO: gotta be a better way to do this. Might be messed up when entering battle with fewer dice?
        if (playerLose)
        {
            if (myDice < 1)
            {
                GameObject.Find("PlayerDice0").SetActive(false);
            }
            else if (myDice < 2)
            {
                GameObject.Find("PlayerDice1").SetActive(false);
            }
            else if (myDice < 3)
            {
                GameObject.Find("PlayerDice2").SetActive(false);
            }
            else if (myDice < 4)
            {
                GameObject.Find("PlayerDice3").SetActive(false);
            }
            else if (myDice < 5)
            {
                GameObject.Find("PlayerDice4").SetActive(false);
            }
        }
        battleDice = GameObject.FindGameObjectsWithTag("Dice");
        enemyBattleDice = GameObject.FindGameObjectsWithTag("EnemyDice");
        playerLose = false;
        Roll();
        yield return new WaitForSeconds(1.5f);
        if (!myTurn)
        {
            EnemyTurn();
        }
    }

    void GameOver () {
        GameObject.Find("StatTracker").GetComponent<PlayerStatsTracker>().myDice = myDice;
    }

    void EnemyGameOver () {
        Cursor.visible = false;
        //GameObject.Find("StatTracker").GetComponent<PlayerStatsTracker>().myDice = myDice;
        //GameObject.Find("EnemyDice0").GetComponent<SpriteRenderer>().enabled = false;
        //GameObject.Find("EnemyGreenWire1").GetComponent<SpriteRenderer>().sortingOrder = 0;
    }

    public IEnumerator NewDice()
    {
        spinnyNewDice.GetComponent<SpriteRenderer>().enabled = true;
        //spinnyNewDice
        yield return new WaitForSeconds(0.1f);
    }

    public IEnumerator EndDialogue()
    {
        yield return new WaitForSeconds(2.5f);
        FindObjectOfType<DialogueManager>().EndDialogue();
    }
}
