using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    class Bullet
    {
        public float time;
        public Vector3 initialPos;
        public Vector3 initialVel;
    }
    public string displayedName;
    public float maxLifeTime = 3.0f;
    public float bulletSpeed = 1000f;
    public float bulletDrop = 1500f;
    List<Bullet> bullets = new List<Bullet>();
    public string animationName;
    public float damage = 10f;


    public bool shoot;
    public ParticleSystem muzzle;
    public float fireSpace = 0.2f;
    public ParticleSystem hitEffect;
    public Transform raycastOrigin;
    public Transform raycastDest;
    public float accumulatedTime;
    public WeaponRecoil recoil;
    Ray ray;
    RaycastHit hit;
    public int fireRate = 5;
    public float lowVib = 0.25f;
    public float highVib = 0.75f;

    private void Awake()
    {
        recoil = GetComponent<WeaponRecoil>();
    }


    Vector3 GetPosition(Bullet bullet)
    {
        //p + v*t + 0.5g * t * t
        Vector3 gravity = bulletDrop * Vector3.down;
        return (bullet.initialPos + (bullet.initialVel * bullet.time) + (0.5f * gravity * bullet.time * bullet.time));
    }
    
    public void StartFiring()
    {
        shoot = true;
        accumulatedTime = 0f;
        FireBullet();
    }

    public void UpdateFire(float deltaTime)
    {
        accumulatedTime += deltaTime;
        float fireInterval = 1.0f / fireRate;
        while (accumulatedTime >= 0f)
        {
            FireBullet();
            accumulatedTime -= fireInterval;
        }
    }

    Bullet CreateBullet(Vector3 position, Vector3 velocity)
    {
        //Gamepad.current.SetMotorSpeeds(lowVib, highVib);
        StartCoroutine(StopHaptic());
        Bullet bullet = new Bullet();
        bullet.initialPos = position;
        bullet.initialVel = velocity;
        bullet.time = 0.0f;
        return bullet;
    }

    IEnumerator StopHaptic()
    {
        yield return new WaitForSeconds(0.10f);
        //Gamepad.current.ResetHaptics();
    }

    public void UpdateBullets(float deltaTime)
    {
        SimulateBullets(deltaTime);
        DestroyBullets();
    }

    void SimulateBullets(float deltaTime)
    {
        bullets.ForEach(bullet =>
        {
            Vector3 p0 = GetPosition(bullet);
            bullet.time += deltaTime;
            Vector3 p1 = GetPosition(bullet);
            RayCastSegment(p0, p1, bullet);
        });
    }

    void RayCastSegment(Vector3 start, Vector3 end, Bullet bullet)
    {
        Vector3 direction = end - start;
        float distance = direction.magnitude;
        ray.origin = start;
        ray.direction = direction;
        if (Physics.Raycast(ray, out hit, distance))
        {
            hitEffect.transform.position = hit.point;
            hitEffect.transform.forward = hit.normal;
            hitEffect.Emit(1);
            bullet.time = maxLifeTime;
            DoDamage(hit.transform.gameObject);
        }
    }

    void DoDamage(GameObject game)
    {
        if (game.tag == "Shootable")
        {
            Rigidbody rb = game.GetComponent<Rigidbody>();
            rb.AddForce(10, 0, 0);
        }
        else if (game.tag == "FBI")
        {
            HitBox box = game.GetComponent<HitBox>();
            if (box)
            {
                box.OnRaycastHit(this, ray.direction);
            }
        }
    }

    void DestroyBullets()
    {
        bullets.RemoveAll(bullet => bullet.time >= maxLifeTime);
    }

    private void FireBullet()
    {
        muzzle.Emit(1);

        Vector3 velocity = (raycastDest.position - raycastOrigin.position).normalized * bulletSpeed;
        var bullet = CreateBullet(raycastOrigin.position, velocity);
        bullets.Add(bullet);

        recoil.GenerateRecoil();
    }

    public void StopFiring()
    {
        shoot = false;
    }

    
}
