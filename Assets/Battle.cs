using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	private int mp = 53;
	public void Magic(){
		if (mp > 4){
			this.mp -= 5;
			Debug.Log("魔法攻撃した。残りMP" + mp + "。");
		}else{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
}

public class Battle : MonoBehaviour{
	void Start () {
		Boss Boss = new Boss();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
		Boss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

