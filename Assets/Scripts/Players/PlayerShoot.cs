using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour {

    public GameObject projectilePrefab;
    private List<Projectile> Projectiles = new List<Projectile>();
	private float timeBetweenShots;
	public float ShotDelay;
    private Animator anim;
    private HurtEnemy P;
    public int currentDamage;

    public enum SHOOTING_DIRECTION
    {
        NONE,
        UP,
        DOWN,
        LEFT,
        RIGHT
    };

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update () {
        bool isMoving = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W);

        if (isMoving && Input.GetKey(KeyCode.A) && Input.GetButton("ShootRight"))
        {
            anim.SetBool("ShootRight", true);
        }
        else
        {
            anim.SetBool("ShootRight", false);
        }
        if (isMoving && Input.GetKey(KeyCode.D) && Input.GetButton("ShootLeft"))
        {
            anim.SetBool("ShootLeft", true);
        }
        else
        {
            anim.SetBool("ShootLeft", false);
        }
        if (isMoving && Input.GetKey(KeyCode.W) && Input.GetButton("ShootDown"))
        {
            anim.SetBool("ShootDown", true);
        }
        else
        {
            anim.SetBool("ShootDown", false);
        }
        if (isMoving && Input.GetKey(KeyCode.S) && Input.GetButton("ShootUp"))
        {
            anim.SetBool("ShootUp", true);
        }
        else
        {
            anim.SetBool("ShootUp", false);
        }
        if (isMoving && Input.GetKey(KeyCode.A) && Input.GetButton("ShootDown"))
        {
            anim.SetBool("ShootLeftFaceDown", true);
        }
        else
        {
            anim.SetBool("ShootLeftFaceDown", false);
        }
        if (isMoving && Input.GetKey(KeyCode.A) && Input.GetButton("ShootUp"))
        {
            anim.SetBool("ShootLeftFaceUp", true);
        }
        else
        {
            anim.SetBool("ShootLeftFaceUp", false);
        }
        if (isMoving && Input.GetKey(KeyCode.D) && Input.GetButton("ShootDown"))
        {
            anim.SetBool("ShootRightFaceDown", true);
        }
        else
        {
            anim.SetBool("ShootRightFaceDown", false);
        }
        if (isMoving && Input.GetKey(KeyCode.D) && Input.GetButton("ShootUp"))
        {
            anim.SetBool("ShootRightFaceUp", true);
        }
        else
        {
            anim.SetBool("ShootRightFaceUp", false);
        }
        if (isMoving && Input.GetKey(KeyCode.W) && Input.GetButton("ShootRight"))
        {
            anim.SetBool("ShootUpFaceRight", true);
        }
        else
        {
            anim.SetBool("ShootUpFaceRight", false);
        }
        if (isMoving && Input.GetKey(KeyCode.W) && Input.GetButton("ShootLeft"))
        {
            anim.SetBool("ShootUpFaceLeft", true);
        }
        else
        {
            anim.SetBool("ShootUpFaceLeft", false);
        }
        if (isMoving && Input.GetKey(KeyCode.S) && Input.GetButton("ShootRight"))
        {
            anim.SetBool("ShootDownFaceRight", true);
        }
        else
        {
            anim.SetBool("ShootDownFaceRight", false);
        }
        if (isMoving && Input.GetKey(KeyCode.S) && Input.GetButton("ShootLeft"))
        {
            anim.SetBool("ShootDownFaceLeft", true);
        }
        else
        {
            anim.SetBool("ShootDownFaceLeft", false);
        }
        if ((!isMoving && Input.GetButton("ShootRight")))
        {
            anim.SetBool("ShootIdleRight", true);
        }
        else
        {
            anim.SetBool("ShootIdleRight", false);
        }
        if ((!isMoving && Input.GetButton("ShootLeft")))
        {
            anim.SetBool("ShootIdleLeft", true);
        }
        else
        {
            anim.SetBool("ShootIdleLeft", false);
        }
        if ((!isMoving && Input.GetButton("ShootUp")))
        {
            anim.SetBool("ShootIdleUp", true);
        }
        else
        {
            anim.SetBool("ShootIdleUp", false);
        }
        if ((!isMoving && Input.GetButton("ShootDown")))
        {
            anim.SetBool("ShootIdleDown", true);
        }
        else
        {
            anim.SetBool("ShootIdleDown", false);
        }
        timeBetweenShots++;
        SHOOTING_DIRECTION dir = Input.GetButton("ShootRight") ?    SHOOTING_DIRECTION.RIGHT : 
                                 Input.GetButton("ShootLeft") ?     SHOOTING_DIRECTION.LEFT :
                                 Input.GetButton("ShootUp") ?       SHOOTING_DIRECTION.UP :
                                 Input.GetButton("ShootDown") ?     SHOOTING_DIRECTION.DOWN : SHOOTING_DIRECTION.NONE;
		if (timeBetweenShots > ShotDelay) {

			if (dir != SHOOTING_DIRECTION.NONE) {
                GameObject P = (GameObject)Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                HurtEnemy pScript = P.GetComponent<HurtEnemy>();
                pScript.damageToGive = pScript.damageToGive + currentDamage;
                Projectile p = new Projectile(P, dir);
                Projectiles.Add(p);
                timeBetweenShots = 0;
            }
		}

        List <Projectile> deleteList = new List<Projectile>();
       
        foreach (Projectile goBullet in Projectiles)
        {
            if (goBullet.IsBulletDead())
            {
                //Agregar a projectiles a borrar
                deleteList.Add(goBullet);
            }
            else
            {
                goBullet.Update(Time.deltaTime);
            }
        }
        //Borrar todos los projectiles que corresponda
        foreach (Projectile delete in deleteList)
        {
            Projectiles.Remove(delete);
            //DestroyObject(delete);
        }
        
    }
   
}
