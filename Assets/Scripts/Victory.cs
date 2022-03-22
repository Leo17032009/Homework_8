using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour 
{
	[SerializeField] private GameObject _victoryPanel;
	[SerializeField] private GameObject _gamePanel;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Victory")) 
		{
			_gamePanel.SetActive (false);
			_victoryPanel.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
