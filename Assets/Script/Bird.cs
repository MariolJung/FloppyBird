using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{

    public float speed = 2;
    public float force = 500;

	// Use this for initialization
	void Start () {

        //velocidad hacia la derecha
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	// Update is called once per frame
	void Update () {

        //Salto del pajarito
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
	}
     void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
