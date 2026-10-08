using System;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float movementSpeed;
    [SerializeField] private Transform playerTransform;
    
    public virtual void Init(Transform player)
    {
        playerTransform = player;
    }

    public abstract void Damage();

    public virtual void PrintEnemyDefense()
    {
        print("10");
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
    }
}
