using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed = 5.0f;
    public GameObject projectile;
    public int health = 3;
    public Text healthUI;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {

        healthUI.text = "Health: " + health;

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }

        if (health <= 0) {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Enemy") {
            print("I hit an Enemy!");
            health = health - 1;
        }
    }
}
