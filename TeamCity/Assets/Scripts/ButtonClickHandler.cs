using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClickHandler : MonoBehaviour
{
	[SerializeField]
	private Text _text;

	public void OnButtonClickHandler()
	{
		_text.text = "Hello world";
	}
}
