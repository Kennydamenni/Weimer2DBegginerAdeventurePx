using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //variables related to player charecter movement
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.0f;


    //Variables related to the health system
    public int maxHealth = 5;
    int currentHealth;
    private Vector2 position;


    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }

        Debug.Log(horizontal);
        
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        transform.position = position;

    }


    // FixedUpdate has the same call rate as the physics system
    private void FixedUpdate()
    {
        Vector2 postion = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }


    void ChangeHealth (int amouunt)
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}

