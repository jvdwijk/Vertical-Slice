using UnityEngine;
using System.Collections;

public class IgnoreLayer : MonoBehaviour {

	[SerializeField]
	private int[] otherLayer;
	[SerializeField]
	private int playerLayer;

	void Start () {
		for (int i = 0; i < otherLayer.Length; i++) {
			Physics2D.IgnoreLayerCollision(otherLayer[i], playerLayer);
		}
	}
}
