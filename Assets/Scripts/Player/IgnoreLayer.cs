using UnityEngine;
using System.Collections;

public class IgnoreLayer : MonoBehaviour {

	[SerializeField]
	private int[] otherLayer;
	[SerializeField]
	private int baseLayer;

	void Start () {
		for (int i = 0; i < otherLayer.Length; i++) {
			Physics2D.IgnoreLayerCollision(otherLayer[i], baseLayer);
		}
	}
}
