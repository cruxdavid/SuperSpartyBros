using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

	public bool taken=false;
	public GameObject explosion;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){
		if ((other.tag == "Player") && !taken && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove)) {
			taken = true;
			if(explosion){
				Instantiate(explosion,transform.position,transform.rotation);
			}
			other.gameObject.GetComponent<CharacterController2D>().CollectLife();
			DestroyObject(this.gameObject);
		}

	}
}
