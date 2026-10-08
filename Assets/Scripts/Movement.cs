using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAsset;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed;
    
    private InputAction _leftAction;
    private InputAction _rightAction;
    
    private void Awake()
    { 
        _leftAction = inputActionAsset.FindActionMap("Player Input").FindAction("Left");
        _rightAction = inputActionAsset.FindActionMap("Player Input").FindAction("Right");
    }
    
    private void OnEnable()
    {
        _leftAction.performed += OnShootPressed;
        _leftAction.Enable();
        
        _rightAction.performed += OnShootPressed;
        _rightAction.Enable();
        
    }

    private void OnShootPressed(InputAction.CallbackContext context)
    {
        Shoot();
    }

    private void MoveRight()
    {
        
    }
}
