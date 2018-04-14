using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] float speed = 8f; 
	[SerializeField] float movableRange = 5.5f;
	[SerializeField] float power = 1000f;
	[SerializeField] GameObject cannonBall; // Prefab化した砲弾オブジェクトをアタッチ
	[SerializeField] Transform spawnPoint; // 砲弾の発射口オブジェクトをアタッチ
		
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -movableRange, movableRange), transform.position.y);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}
	}

	void Shoot() {
		GameObject newBullet = Instantiate (cannonBall, spawnPoint.position, Quaternion.identity) as GameObject; // Quaternion.identity: 角度Rotation 0,0,0 で生成
		newBullet.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * power); // AddForceで物理的な力を加える
	}
}
