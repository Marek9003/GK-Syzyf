using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 25;
    public Rigidbody rb;
    public Animator anim;
    float horizontalInput;
    public float horizontalMultiplier = 2;

    private Vector3 startPos;
    
    
    private void Start()
    {
        rb=this.GetComponent<Rigidbody>();
        startPos = rb.position;
        
    }


    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
       

    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            ResetGame();
        }
           
    }

    public float GetSpeed()
    {
        return speed;
    }
  

    void ResetGame()
    {
        rb.position = startPos;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }


}
