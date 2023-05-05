using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletinBoard : MonoBehaviour
{
    [SerializeField] private bool _hasNewQuest = true;
    
    private GameObject _QuestionMark;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Awake()
    {
        _QuestionMark = transform.Find("QuestionMark").gameObject;
    }

    private void Update()
    {
        _QuestionMark.SetActive(_hasNewQuest);
    }
    
}