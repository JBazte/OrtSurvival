using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile {

    private GameObject thisBulletobject;
    public float projectileVelocity = 15f;
    private bool IsDead = false;
    private PlayerShoot.SHOOTING_DIRECTION direction;

    // Use this for initialization
    public Projectile(GameObject bulletObject, PlayerShoot.SHOOTING_DIRECTION dir)
    {
        thisBulletobject = bulletObject;
        direction = dir;
    }

	void Start () {
        
    }
    
    // Update is called once per frame
    public void Update(float DeltaTime)
    {
        if (thisBulletobject != null)
        {
            Vector3 transformation = new Vector3(0, 0, 0);
            float transformationVelocity = DeltaTime * projectileVelocity;
            switch (direction)
            {
                case PlayerShoot.SHOOTING_DIRECTION.UP:
                    transformation.y = transformationVelocity;
                    break;
                case PlayerShoot.SHOOTING_DIRECTION.DOWN:
                    transformation.y = -transformationVelocity;
                    break;
                case PlayerShoot.SHOOTING_DIRECTION.LEFT:
                    transformation.x = -transformationVelocity;
                    break;
                case PlayerShoot.SHOOTING_DIRECTION.RIGHT:
                    transformation.x = transformationVelocity;
                    break;
            }

            thisBulletobject.transform.Translate(transformation);            
        }
    }
    
    public bool IsBulletDead()
    {
        return IsDead;
    }
}
