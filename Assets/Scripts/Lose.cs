using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour 
{
	[SerializeField] private GameObject _losePanel; //Создаём панель проигрыша
	[SerializeField] private GameObject _gamePanel;//Создаём панель игры

	private void OnTriggerEnter(Collider other) //Если объект косается препятствия, то:
	{
		if (other.gameObject.CompareTag("Obstacle")) 
		{
			_gamePanel.SetActive (false); //Значение панели игры = false
			_losePanel.SetActive (true); // Значение панели проигрыша = true
			Time.timeScale = 0;
		}
	}
}