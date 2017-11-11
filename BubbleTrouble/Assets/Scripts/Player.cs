using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour {

    public static int adCall = 0;

    public Animator animator;

    public static float speed = 4f;

    public Rigidbody2D rb;

    public static float movement = 0f;


    



    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x > 400 && Input.mousePosition.y < 165)
            {
                movement = 1 * speed;
            }else if (Input.mousePosition.x < 400 && Input.mousePosition.y < 165)
            {
                movement = -1 * speed;
            }

        }else
        {
            movement = 0 * speed;

        }


    }
	

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime,0f));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Ball")
        {
            animator.SetTrigger("Loss");
            if(adCall == 3)
            {
                Advertisement.Show();
            }
            else
            {
                adCall++;
            }
        }
    }
}
