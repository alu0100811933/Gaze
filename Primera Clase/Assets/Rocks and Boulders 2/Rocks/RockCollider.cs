using UnityEngine;
using System.Collections;

public class RockCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Choque.CambiarC += Cambio;
	}

	void Cambio() {
	// Destroy (this.gameObject);
		this.gameObject.transform.Rotate(Vector3.up, 40, Space.World);

		Color newColor = new Color (Random.value, Random.value, Random.value);

		this.gameObject.GetComponent<Renderer> ().material.color = newColor;
	}
	// Update is called once per frame
	void Update () {
	}
}
