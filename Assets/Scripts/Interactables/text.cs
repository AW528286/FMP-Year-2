using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : Interactable
{
    [SerializeField]
    private GameObject Text;
    private bool Texting;
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
        Debug.Log("absabdsbjddbjzsbjs");
        Texting = !Texting;
        Text.GetComponent<Animator>().SetBool("Texting", Texting);
    }
}
