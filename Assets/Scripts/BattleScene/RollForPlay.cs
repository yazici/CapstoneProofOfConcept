﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollForPlay : MonoBehaviour {

    public bool turn;

    float turnTime = 0.02f;

    private void Start()
    {
      //  StartCoroutine(OpTurn());
    }

    public void Spin() {
        float temp = Random.value;
        if (temp < 0.5f)
        {
            turn = true;
            StartCoroutine(MyTurn());
        }
        else
        {
            turn = false;
            StartCoroutine(OpTurn());
        }
    }

    IEnumerator MyTurn()
    {
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y * 1.3f);
        yield return new WaitForSeconds(0.2f);
        this.transform.localScale = new Vector3(transform.localScale.x * 0.77f, transform.localScale.y * 0.77f);
        yield return new WaitForSeconds(0.2f);
        GameObject.Find("BattleManager").GetComponent<BattleManager>().myTurn = true;
        this.gameObject.SetActive(false);
    }

    IEnumerator OpTurn()
    {
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 195);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 210);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 225);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 240);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 255);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 270);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 285);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 300);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 315);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 330);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 345);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 360);
        yield return new WaitForSeconds(turnTime * 2);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 15);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 30);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 60);
        yield return new WaitForSeconds(turnTime * 3);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 75);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 105);
        yield return new WaitForSeconds(turnTime * 4);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 120);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 135);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 150);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 165);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180);
        yield return new WaitForSeconds(turnTime * 8);
        this.transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y * 1.3f);
        yield return new WaitForSeconds(0.2f);
        this.transform.localScale = new Vector3(transform.localScale.x * 0.77f, transform.localScale.y * 0.77f);
        yield return new WaitForSeconds(0.2f);
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        GameObject.Find("BattleManager").GetComponent<BattleManager>().EnemyTurn();

    }
}
