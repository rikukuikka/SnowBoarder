using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustTrailEffect;
    [SerializeField] private bool playDustTrail = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            playDustTrail = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            playDustTrail = false;
        }
    }

    private void Update()
    {
        if (playDustTrail)
        {
            dustTrailEffect.Play();
        }
    }
}
