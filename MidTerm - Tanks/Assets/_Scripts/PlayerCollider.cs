using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// Use this for initialization
    public GameController gameController;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           
            this.gameController.LivesValue -= 1;
        }
        
        
    }
}
