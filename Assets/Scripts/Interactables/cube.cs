using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : Interactable
{
    [SerializeField]
    private GameObject Cube;
    private bool Taken;
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
        Taken = !Taken;
        Cube.GetComponent<Animator>().SetBool("Taken", Taken);
    }
}
