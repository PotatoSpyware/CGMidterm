using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] float bounce;
    [SerializeField] Rigidbody rb;

    [SerializeField] GameObject Score;
    [SerializeField] Material litMat;
    [SerializeField] Shader[] shaders;
    int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Basket")
        {
            rb.AddForce(new Vector3(0, bounce, 0));
            Score.SetActive(false);
        }

        else
        {
            score++;
            Score.SetActive(true);
            litMat.shader = shaders[score%3];
            rb.AddForce(new Vector3(0, bounce, 0));
        }
    }
}
