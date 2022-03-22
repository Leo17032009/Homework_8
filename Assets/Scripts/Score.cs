using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	[SerializeField] private Text _scoreTextGame;
	[SerializeField] private Text _scoreTextLose;
	[SerializeField] private Text _scoreTextVictory;
	private int _score;
	private Bonus _bonus;
	private int _valueBonus;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Bonus")) 
		{
			Bonus _bonus = other.gameObject.GetComponent<Bonus>();
			_valueBonus = _bonus.bonus;
			UpdateScore();
			Destroy (other.gameObject);
		}
	}

	private void UpdateScore()
	{
		_score += _valueBonus;
		_scoreTextGame.text = _score.ToString ();
		_scoreTextLose.text = _score.ToString ();
		_scoreTextVictory.text = _score.ToString ();
	}
}
