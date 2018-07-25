using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangPostion : MonoBehaviour {

	[SerializeField]
	Slider slider;
	
	void Update () {
		this.transform.position=new Vector3(0,0,-slider.value);
	}
}
