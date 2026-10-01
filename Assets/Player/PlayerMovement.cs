using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movementInput;
    [SerializeField] private float jumpForce;
    
    [SerializeField] private float Speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    public void Update()
    {
        transform.position += new Vector3(movementInput, 0, 0) * Speed * Time.deltaTime;
        //Debug.Log("Deltatime: " + Time.deltaTime + "; Speed: "
        //ShowRay();

    }
    public void Jump()
    {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);

   
    }
  
    //private void ShowRay()
    //{
    //    Debug.DrawRay(transform.position, Vector2.down * 0.1f, Color.red);
    //}
}
