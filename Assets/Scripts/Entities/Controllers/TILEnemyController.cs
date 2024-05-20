using UnityEngine;

public class TILEnemyController : TILController
{
    GameManager gameManager;
    protected Transform ClosestTarget { get; private set; }

    protected override void Awake()
    {
        base.Awake();
    }

    protected virtual void Start()
    {
        gameManager = GameManager.Instance;
        ClosestTarget = gameManager.Player;
    }

    protected virtual void FixedUpdate()
    {

    }

    protected float DistanceToTarget()
    {
        return Vector3.Distance(new Vector3(transform.position.x,0,0),new Vector3(ClosestTarget.position.x,0,0));
    }

    protected Vector2 DirectionToTarget()
    {
        return (new Vector3(ClosestTarget.position.x,0,0) - new Vector3(transform.position.x,0,0)).normalized;
    }

}