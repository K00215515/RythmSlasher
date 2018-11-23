using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public Text countText;
    private Rigidbody rb;
    private int count;

    void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();

    }
	
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            
        }
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count == 10)
        {
            SceneManager.LoadScene("EndScene");
        }

    }
}
