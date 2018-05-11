using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IwateManager : MonoBehaviour {
    public GameObject emo01;
    public EmoManager emoManager;
    public UiManager uiManager;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //
    void OnMouseDown() {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Touch : " + worldPos);
        uiManager.SetTouchPos(worldPos);
        uiManager.UpdateUI();
        emoManager.FadeOut();
        iTween.PunchScale(this.gameObject, iTween.Hash(
            "x", 0.3f,
            "y", 0.3f,
            "time", 0.5
        ));
    }
}
