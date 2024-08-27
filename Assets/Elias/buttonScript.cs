using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {
    [Header("Values to adjust, depricated")]
    public float timeTillAnimFinished = 1;
    public float steps = 100;

    [Header("Ting som er public, men er fuldstændig ligegyldige")]
    public bool moving = false;
    public bool red = false;
    public Animator æ;
    public void buttonPress() {
        /*i*///f (moving) return;
        buttonAnim();
    }
    public void buttonAnim() {
        float initY = GetComponent<RectTransform>().localPosition.y;
        if (moving) {
            æ.Play("un_uf");
            moving = false;
            GetComponent<Image>().color = Color.red;
        }
        else {
            moving = !
            moving;
            æ.Play("fu_nu");
            GetComponent<Image>().color = Color.green;
        }
    }
}
