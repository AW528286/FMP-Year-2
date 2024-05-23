using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : Interactable
{
    [SerializeField]
    private GameObject fence;
    private bool IsOpen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        IsOpen = !IsOpen;
        fence   .GetComponent<Animator>().SetBool("IsOpen", IsOpen);
    }
}
