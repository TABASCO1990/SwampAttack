using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int _shootOffset = 7;
    [SerializeField] private int _bulletCount = 3;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletCount; i++)
        {
            GenerationBullets(Random.Range(-_shootOffset, _shootOffset), shootPoint);
        }
    }

    private void GenerationBullets(int offset, Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(Vector3.forward * offset));
    }
}
