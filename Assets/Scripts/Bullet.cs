using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1);

        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<Zombie>().Destroy();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }
}
