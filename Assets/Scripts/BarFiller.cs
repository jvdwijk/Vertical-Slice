using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarFiller : MonoBehaviour {
	[SerializeField]
	private Image staminaBar;

	void Start () {
		staminaBar.fillAmount = 0.5f;
		InvokeRepeating ("IncreaseBar", 2, 2);
	}

	private void IncreaseBar()
	{
		Debug.Log ("asfhiuog");
		if(staminaBar.fillAmount < 1)
			staminaBar.fillAmount += 1/6f;
	}

}
