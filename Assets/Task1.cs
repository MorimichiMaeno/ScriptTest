using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = {10, 20, 60, 50, 80};

        //配列の各要素の値を順番に表示
        //for (int i = 0; i <= array.Length; i++) {
        //    Debug.Log(array[i]);
        //}

        //for文を使い、配列の各要素の値を逆順に表示
        for (int j = array.Length - 1; j >= 0; j--) {
            Debug.Log(array[j]);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
