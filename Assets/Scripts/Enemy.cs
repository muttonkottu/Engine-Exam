using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject bill;
    [SerializeField] private GameObject boll;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform enemyTransform;

    private void Start()
    {
        Bullet bill1 = CreateBullet("bill");
        Bullet boll1 = CreateBullet("boll");
        
        bill1.Damage();
        boll1.Damage();
        
        bill1.PrintEnemyDefense();
        boll1.PrintEnemyDefense();
    }
    
    private Bullet CreateBullet(string nam)
    {
        if (nam == "bill")
        {
            GameObject bullet = Instantiate(bill, enemyTransform);
            var bulletComponent = bullet.GetComponent<Bullet>();
            bulletComponent.Init(playerTransform);
            return bulletComponent;
        }
        else
        {
            GameObject bullet = Instantiate(boll, enemyTransform);
            var bulletComponent = bullet.GetComponent<Bullet>();
            bulletComponent.Init(playerTransform);
            return bulletComponent;
        }
    }
}
