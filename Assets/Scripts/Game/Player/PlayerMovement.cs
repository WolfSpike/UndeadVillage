using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void MovementUpdate()
    {
        InputMove(KeyCode.W, Vector3.up);
        InputMove(KeyCode.S, -Vector3.up);
        InputMove(KeyCode.A, Vector3.left);
        InputMove(KeyCode.D, -Vector3.left);
    }

    private void InputMove(KeyCode key, Vector3 direction)
    {
        if (Input.GetKey(key))
        {
            var moveDirection = direction.normalized * Player.Instance.UnitModel.Speed;
            transform.position += moveDirection * Time.deltaTime;
        }
    }
}
