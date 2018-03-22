using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;//体力
    private int power = 25;//攻撃力
    private int mp = 53;//魔力

    //攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //魔法攻撃の関数
    public void Magic() {
        if (mp > 4) {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }

    //防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //魔法攻撃の関数を呼び出す
        lastboss.Magic();
        for (int i = 0; i < 10; i++) {
            lastboss.Magic();
        }
        //防御用の関数を呼び出す
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update() {

    }
}