using UnityEngine;
using System.Collections;

public class IgnoreLayer : MonoBehaviour {

	[SerializeField]
	private int LayerOne;
	[SerializeField]
	private int LayerTwo;

	void Start () {
		Physics2D.IgnoreLayerCollision(LayerOne, LayerTwo);
	}
}
