using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movementInput;
    [SerializeField] private float Speed;

    // Update is called once per frame
    public void Update()
    {
        transform.position += new Vector3(movementInput, 0, 0) * Speed * Time.deltaTime;
        //Debug.Log("Deltatime: " + Time.deltaTime + "; Speed: "
    }
}
