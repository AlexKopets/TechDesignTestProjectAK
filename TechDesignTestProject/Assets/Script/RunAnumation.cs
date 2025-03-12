using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RunAnumation : MonoBehaviour, IPointerClickHandler
{
    private Animator _animation;
         void Start()
    {
        _animation = GetComponent<Animator>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _animation.SetInteger("Touch",1);
    } 
    public void EndAimation()
    {
        _animation.SetInteger("Touch",0);
    }

    
}
