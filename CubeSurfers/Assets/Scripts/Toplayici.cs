using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject maincube;
    public int height;
    public MenuInGame menuingame;
    void Start()
    {
        maincube = GameObject.Find("MainCube");
        
    }

    // Update is called once per frame
    void Update()
    {
        maincube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
        
    }
    public void ReduceHeight()
    {
        height--;
        menuingame.score -= 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AdditionalCube" && other.gameObject.GetComponent<AdditionScript>().getIsPicked() == false)
        {
            menuingame.score += 1;
            height += 1;
            other.gameObject.GetComponent<AdditionScript>().makePicked();
            other.gameObject.GetComponent<AdditionScript>().setIndex(height);
            other.gameObject.transform.parent = maincube.transform;
        }
        if (other.gameObject.tag == "Finish")
        {
            menuingame.FinishMenu();
        }

    }
}
