using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [Header("Statistics")]
    public float speed = 3;
    public float rotationSpeed = 3;
    public bool movesBackward = false;

    [Header("Controller")]
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    private CharacterController _controller;
    
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        var hMove = Input.GetAxis(horizontalAxis);
        var vMove = Input.GetAxis(verticalAxis);

        if (!movesBackward)
        {
            vMove = Mathf.Clamp(vMove, 0, 1);
        }
        
        transform.Rotate(0, hMove * rotationSpeed, 0);

        var forward = transform.TransformDirection(Vector3.forward);
        _controller.SimpleMove(speed * vMove * forward);
    }
}
