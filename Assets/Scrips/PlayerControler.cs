using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControler : MonoBehaviour
{
    public float MoveSpeed=5f  ;

    Vector3 moveInput= Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController= GetComponent<CharacterController>();
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveInput = transform.TransformDirection(moveInput) * MoveSpeed;

        characterController.Move(moveInput*Time.deltaTime);
    }
}
