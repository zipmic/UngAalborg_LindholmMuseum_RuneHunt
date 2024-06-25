using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RuneManager : MonoBehaviour {
    public int maxRunes = 16;
    public TextMeshProUGUI collectedText;
    private List<int> collectedRunes = new List<int>();

    public List<int> getCollectedRunes() {
        return collectedRunes;
    }
    public void addRune(int i) {
        if(i > maxRunes || i < 0) throw new KeyNotFoundException();
        if (collectedRunes.Contains(i)) return;
        collectedRunes.Add(i);
    }
    public bool isAllCollected() {
        if (collectedRunes.Count == maxRunes) return true;
        return false;
    }
    public bool isCollected(int i) {
        if (collectedRunes.Contains(i)) return true;
        return false;
    }
    private void Update() {
        collectedText.text = "Samlet: " + collectedRunes.Count + " / " + maxRunes;
    }
}
