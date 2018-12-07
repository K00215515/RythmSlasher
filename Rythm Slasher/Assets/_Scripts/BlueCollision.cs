using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlueCollision : MonoBehaviour {

    public Text scoreText;
    private Rigidbody rb;
    private int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SphereTarget"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(true);
            score -= 1;
            SetScoreText();
        }
    }

    public void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
