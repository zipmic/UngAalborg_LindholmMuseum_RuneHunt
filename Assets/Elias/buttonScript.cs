using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    [Header("Values to adjust")]
    public float timeTillAnimFinished = 1;
    public float steps = 100;

    [Header("Ting som er public, men er fuldstændig ligegyldige")]
    public bool moving = false;
    public bool red = false;
    public void buttonPress() {
        if (moving) return;
        StartCoroutine(buttonAnim());
    }
    public IEnumerator buttonAnim() {
        float initY = GetComponent<RectTransform>().localPosition.y;
        float stopY = GetComponent<RectTransform>().localPosition.y * -1;
        moving = true;
        for (float newY = initY; Mathf.Abs(newY) <= Mathf.Abs(stopY); newY += stopY / steps) {
            GetComponent<RectTransform>().localPosition = new Vector3(GetComponent<RectTransform>().localPosition.x, newY, GetComponent<RectTransform>().localPosition.z);
            yield return new WaitForSeconds(timeTillAnimFinished / steps);
        }
        GetComponent<RectTransform>().localPosition = new Vector3(GetComponent<RectTransform>().localPosition.x, stopY, GetComponent<RectTransform>().localPosition.z);
        if (red) {
            GetComponent<TextMeshProUGUI>().color = Color.green;
            red = false;
        }
        else {
            GetComponent<TextMeshProUGUI>().color = Color.red;
            red = true;
        }
        
        moving = false;
    }
}
