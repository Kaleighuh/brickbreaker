using UnityEngine.InputSystem;
using UnityEngine;

public class TouchManagerScript : MonoBehaviour
{
    [SerializeField] 
    private GameObject player;
    private PlayerInput playerInput;
    private InputAction touchPositionAction;
    private InputAction touchPressAction;
    private bool isDragging;
    private Vector3 startPosition;
    
    void Start()
    {
        startPosition = player.transform.position; 
    }
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions.FindAction("TouchPress");
        touchPositionAction = playerInput.actions.FindAction("TouchPosition");
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
        touchPressAction.performed += StartDrag;
        touchPressAction.canceled += EndDrag;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
        position.z = player.transform.position.z;
        player.transform.position = position;

    }
    private void StartDrag(InputAction.CallbackContext context)
    {
        isDragging = true;
    }

    private void EndDrag(InputAction.CallbackContext context)  
    {
        isDragging = false;
    }

    private void Update()
    {
        if (touchPositionAction.WasPerformedThisFrame())
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
            position.z = player.transform.position.z;
            player.transform.position = position;
        }
        if (isDragging) 
        {
            Vector2 inputPos = touchPositionAction.ReadValue<Vector2>();

            if (inputPos == Vector2.zero) 
            {  
                inputPos = Mouse.current.position.ReadValue(); 
            }
    
            var worldPos = startPosition;
            worldPos.y = Camera.main.ScreenToWorldPoint(inputPos).y;

            player.transform.position = worldPos;
            
        }
    }
    
}