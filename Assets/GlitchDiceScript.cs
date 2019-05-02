﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchDiceScript : MonoBehaviour {

    public Sprite oldSprite;
    public Sprite newSprite;
    public GenDiceScript newDice;
    SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        sr = this.GetComponent<SpriteRenderer>();
	}

    public IEnumerator GlitchMe()
    {
        yield return new WaitForSeconds(0.1f);
        sr.sprite = newSprite;
        yield return new WaitForSeconds(0.5f);
        sr.sprite = oldSprite;
        yield return new WaitForSeconds(0.3f);
        sr.sprite = newSprite;
        yield return new WaitForSeconds(0.1f);
        sr.sprite = oldSprite;
        yield return new WaitForSeconds(0.05f);
        sr.sprite = newSprite;
        yield return new WaitForSeconds(0.1f);
        sr.sprite = oldSprite;
        yield return new WaitForSeconds(0.05f);
        sr.sprite = newSprite;
        yield return new WaitForSeconds(0.1f);
        sr.sprite = oldSprite;
        yield return new WaitForSeconds(0.05f);
        sr.sprite = newSprite;
        yield return new WaitForSeconds(0.1f);
        sr.sprite = oldSprite;
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<BaseDiceScript>().diceProfile = newDice;
    }
}
