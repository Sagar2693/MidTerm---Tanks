using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	// Use this for initialization
    public GameController gameController;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {

            this.gameController.ScoreValue += 100;
        }


    }

}
