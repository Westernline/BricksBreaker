using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningTrigger : MonoBehaviour
{
    public GameObject WarningBg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Target")
        {
            if(WarningBg.activeSelf==false)
            WarningBg.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Target")
        {
            if(WarningBg.activeSelf==true)
            WarningBg.SetActive(false);
        }
        if (collision.transform.tag == "Block")
        {
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "score")
        {
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "death")
        {
            Destroy(collision.gameObject);
        }
    }


    
}
