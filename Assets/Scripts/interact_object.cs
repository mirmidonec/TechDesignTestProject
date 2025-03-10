using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
[RequireComponent (typeof(AudioSource))]
public class interact_object : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    public ParticleSystem vfx;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        vfx.gameObject.SetActive(true);
        animator.SetTrigger("Click");
        Invoke("Off",0.2f);
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    private void Off(){
        vfx.gameObject.SetActive(false);
    }
}
