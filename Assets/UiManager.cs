using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {
    public Text textNum;
    public Text textMessage;
    int paramLove;
    int paramPopulation;
    int paramCute;
    int paramCool;
    int paramPassion;
    int randNum;
    Vector3 touchPos;

    // Use this for initialization
    void Start () {
        paramLove = 0;
        paramPopulation = 0;
        paramCute = 0;
        paramCool = 0;
        paramPassion = 0;
        UpdateParam();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //UIの更新（外部からコールされる）
    public void UpdateUI() {
        AddParam();
        UpdateParam();
        UpdateMessage();
    }

    //乱数で選んだパラメータの加算
    void AddParam() {
        paramLove++;
        randNum = Random.Range(1, 5);   //1 to 4
        switch (randNum) {
            case 1:
                paramPopulation++;
                break;
            case 2:
                paramCute++;
                break;
            case 3:
                paramCool++;
                break;
            case 4:
                paramPassion++;
                break;
        }
    }

    //パラメータの更新
    void UpdateParam() {
        string paramText;
        paramText = paramLove + "\n"
            + paramPopulation + "\n"
            + "<color=#ff99bb>" + paramCute + "</color>\n"
            + "<color=#aaaaff>" + paramCool + "</color>\n"
            + "<color=#ffffaa>" + paramPassion + "</color>";
        textNum.text = paramText;
    }

    //メッセージの更新
    void UpdateMessage() {
        int randNum2;
        string message = "";
        switch (randNum) {
            case 1: //人口
                randNum2 = Random.Range(1, 8+1);   //1 to 8
                if (randNum2 == 1) message = "雨にも負けず…なんでしたっけ？";
                if (randNum2 == 2) message = "いっぱい触ったら岩手に行きたくなりますよ";
                if (randNum2 == 3) message = "ソフトクリーム食べに花巻へ行きましょうか？";
                if (randNum2 == 4) message = "牛乳飲みに小岩井へ行きましょうか？";
                if (randNum2 == 5) message = "あのパン食べに盛岡へ行きましょうか？";
                if (randNum2 == 6) message = "のんびり銀河鉄道の旅とかどうですか？";
                if (randNum2 == 7) message = "とりあえず平泉へ行ってみるのはどうですか？";
                if (randNum2 >= 8) {
                    //touchPos.yで県北、県南、その他へ分岐
                    if (touchPos.y > 0.5f) {
                        message = "県北もいいですけど県南も触ってくださいね";
                    } else if (touchPos.y < -0.8f) {
                        message = "県南もいいですけど県北も触ってくださいね";
                    } else {
                        message = "次はどのへんを触ります？";
                    }
                }
                break;
            case 2: //Cute
                randNum2 = Random.Range(1, 4+1);   //1 to 4
                if (randNum2 == 1) message = "はわわ、はずかしいです…";
                if (randNum2 == 2) message = "なんだか照れちゃいますね…";
                if (randNum2 == 3) message = "えへへ、なんだかいいですね";
                if (randNum2 >= 4) message = "えっ？　クマいました！？";
                break;
            case 3: //Cool
                randNum2 = Random.Range(1, 5+1);   //1 to 5
                if (randNum2 == 1) message = "いま…変なところ触りました？";
                if (randNum2 == 2) message = "あの…あんまり触るとアレですから";
                if (randNum2 == 3) message = "いまのはちょっとアレだったかな…";
                if (randNum2 == 4) message = "そんなにアレなら岩手に来たらいいじゃないですか";
                if (randNum2 >= 5) message = "浄土ヶ浜でカニとたわむれます？";
                break;
            case 4: //Passion
                randNum2 = Random.Range(1, 4+1);   //1 to 4
                if (randNum2 == 1) message = "はい、がんばります！";
                if (randNum2 == 2) message = "はい、ありがとうございます！";
                if (randNum2 == 3) message = "今日も一日がんばります！";
                if (randNum2 >= 4) message = "雨にも負けずがんばりましょう！";
                break;
        }
        textMessage.text = "【岩手県】\n" + message;
    }

    //タッチした座標セット
    public void SetTouchPos(Vector3 pos) {
        touchPos = pos;
    }
}
