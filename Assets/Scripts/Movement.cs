using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAsset;
    [SerializeField] private Rigidbody2D player;
    
    private InputAction _leftAction;
    private InputAction _rightAction;
    
    private void Awake()
    { 
        _leftAction = inputActionAsset.FindActionMap("Player").FindAction("Left");
        _rightAction = inputActionAsset.FindActionMap("Player").FindAction("Right");
    }
    
    private void OnEnable()
    {
        _leftAction.performed += OnLeftPressed;
        _leftAction.Enable();
        
        _rightAction.performed += OnRightPressed;
        _rightAction.Enable();
        
    }

    private void OnLeftPressed(InputAction.CallbackContext context)
    {
        MoveLeft();
    }
    
    private void OnRightPressed(InputAction.CallbackContext context)
    {
        MoveRight();
    }

    // i forgot how to make movement
    private void MoveRight()
    {
        print("MOVING RIGHT");
        player.linearVelocity = new Vector2(player.linearVelocity.x, 0);
    }
    
    private void MoveLeft()
    {
        print("MOVING LEFT");
        player.linearVelocity = new Vector2(-player.linearVelocity.x, 0);
    }
}
