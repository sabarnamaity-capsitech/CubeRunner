using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerScript playerScript;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;

    public ScoreText score;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            score.AddScore(1);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            

            gameController.GameOver();
            playerScript.enabled=false;
            audioSource1.Play();
            

        }
    }
}
