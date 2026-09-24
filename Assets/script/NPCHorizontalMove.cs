using UnityEngine;
public class NPCHorizontalMove : MonoBehaviour
{
    private float speed = 15f; // Speed of the NPC movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(1, 0, 0); 

        transform.Translate(direction * speed * Time.deltaTime); 

      
    }
}
