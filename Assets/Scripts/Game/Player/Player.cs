using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _movement;

    public static Player Instance;

    public BaseUnit UnitModel;

    public void Awake()
    {
        PlayerInit();
    }

    public void Update()
    {
        _movement.MovementUpdate();
    }

    public void PlayerInit()
    {
        Instance = this;
        UnitModel = new BaseUnit(5f);
    }
}
