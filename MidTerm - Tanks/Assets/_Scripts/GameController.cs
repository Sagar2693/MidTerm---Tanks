using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
    private int _scoreValue;
    private int _livesValue;
    // PUBLIC INSTANCE VARIABLES
	public int tankCount;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
	public GameObject tank;
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }
    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                //this._endGame();
            }
            else
            {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }
    }
    //private void _initialize()
    //{
    //    this.ScoreValue = 0;
    //    this.LivesValue = 5;
    //    this.GameOverLabel.gameObject.SetActive(false);
    //}
	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.GameOverLabel.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}
}
