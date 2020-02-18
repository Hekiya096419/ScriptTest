using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//要素数5の配列を初期化する
		int[] points = {560, 68, 9873, 23, 784};
		//配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++){
			Debug.Log (points [i]);
		}
		for (int i = 4; i >= 0; i--) {
			Debug.Log (points [i]);
		}
	}
		// Update is called once per frame
	void Update () {
		
	}
}