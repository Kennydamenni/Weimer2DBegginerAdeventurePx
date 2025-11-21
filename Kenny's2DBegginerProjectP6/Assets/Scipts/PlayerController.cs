using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class NewBehaviourScript : MonoBehaviour
{

    public InputAction LeftAction;
    // Start is called before the first frame update
    void Start()
    {
        LeftAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        if (LeftAction.IsPressed())
        {
            horizontal = -1.0f;
        }

        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);

        float vertical = 0.0f;
        if (Keyboard.current.upArrowKey.isPressed)
        {  
            vertical = 1.0f;
        }
        else if ( Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        Debug.Log(vertical);

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        transform.position = position;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;




    }
}
