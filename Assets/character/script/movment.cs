using UnityEngine;
using UnityEngine.SceneManagement;
public class movment : MonoBehaviour
{
    bool alive = true;


    public float speed = 5;
    public Rigidbody Rb;

    float horizontalInput;
    public float horizontalmultiplayer = 2;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalmultiplayer;
        Rb.MovePosition(Rb.position + forwardmove + horizontalmove);
    }
    private void Update()
    {
        if(alive == false)
        {
            return;
        }
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -100)
        {
            Die();
        }

    }

    public void Die()
    {
        alive = false;
        
        //Invoke("restart", 2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "obstacle")
        {
            Die();
        }
    }


    //void restart()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}


}
