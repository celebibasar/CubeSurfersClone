using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionScript : MonoBehaviour
{
    bool isPicked;
    int index;
    public Toplayici toplayici;
    void Start()
    {
        isPicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPicked == true)
        {
            if (transform.parent != null)
            {
                this.transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Block")
        {
            toplayici.ReduceHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }
    public bool getIsPicked()
    {

        return isPicked;
    }

    public void makePicked()
    {
        isPicked = true;
    }

    public void setIndex(int index)
    {
        this.index = index;
    }
}
