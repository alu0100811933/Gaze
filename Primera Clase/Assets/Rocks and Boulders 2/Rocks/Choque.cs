using UnityEngine;
using System.Collections;

public class Choque : MonoBehaviour {
	public delegate void cambiarColor ();

	public static cambiarColor CambiarC;

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Transformer") {
			CambiarC();
		}
			
}
}