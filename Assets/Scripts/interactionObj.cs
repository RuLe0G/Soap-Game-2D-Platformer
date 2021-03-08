using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionObj : MonoBehaviour
{


    [SerializeField]
    public ScriptableObject ActoinScr; //скрипт

    public string Tooltip;
    public GameObject Tooltip_GO;

    public Collider2D Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Player)
        {
            Tooltip_GO.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == Player)
        {
            Tooltip_GO.SetActive(false);
        }
    }

    public void Action()
    {
        gameObject.SetActive(false);
        //ActoinScr.Action();
    }

    
}

