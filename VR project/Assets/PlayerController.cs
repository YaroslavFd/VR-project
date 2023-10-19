using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private int score = 10;
    public Text scoreText;


    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        if (score <= 0)
        {
            Destroy(gameObject);
            scoreText.text = "Игра окончена";
        }
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;

            transform.Translate(movement);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = 10;
            UpdateScoreText();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            score--;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
