using UnityEngine;
using Chapter.Singleton;

public class GameManager : Singleton<GameManager>
{
    private int _bulletsLeft = 5;

    public void BulletShot()
    {
        _bulletsLeft--;
        if (_bulletsLeft <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        print("Game Over!!!");
    }
}
