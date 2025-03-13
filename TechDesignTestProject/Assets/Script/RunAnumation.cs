using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RunAnumation : MonoBehaviour, IPointerClickHandler
{
    private Animator _animation;
    private AudioSource touchSound;
         void Start()
    {
        _animation = GetComponent<Animator>();
        touchSound = GetComponent<AudioSource>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _animation.SetInteger("Touch",1);
        touchSound.Play();
    } 
    public void EndAimation()
    {
        _animation.SetInteger("Touch",0);
    }

    
}
