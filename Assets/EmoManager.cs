using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoManager : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FadeIn() {
        // SetValue()を毎フレーム呼び出して、１秒間に０から１までの値の中間値を渡す
        iTween.ValueTo(gameObject, iTween.Hash("from", 0f, "to", 1f, "time", 1f, "onupdate", "SetValue"));
    }
    public void FadeOut() {
        // SetValue()を毎フレーム呼び出して、１秒間に１から０までの値の中間値を渡す
        iTween.ValueTo(gameObject, iTween.Hash("from", 1f, "to", 0f, "time", 1f, "onupdate", "SetValue"));
    }
    void SetValue(float alpha) {
        // iTweenで呼ばれたら、受け取った値をImageのアルファ値にセット
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, alpha);
    }

}
