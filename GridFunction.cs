using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFunction : MonoBehaviour
{
    public GameObject grid_2d;
    public GameObject upDown;
    public GameObject frontBack;
    public GameObject player;
    public GameObject target;
    public GameObject target_2;
    public GameObject text_preUpDown;
    public GameObject text_upDown;
    public GameObject text_grid;
    public GameObject text_preFrontBack;
    public GameObject text_frontBack;
    public GameObject text_circles;
    public GameObject text_target_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text_preUpDown.gameObject.activeSelf)
        {
            upDown.gameObject.SetActive(false);
        }
        else if (text_upDown.gameObject.activeSelf)
        {
            upDown.gameObject.SetActive(true);
        }

        if (text_upDown.gameObject.activeSelf)
        {
            grid_2d.gameObject.SetActive(false);
        }
        else if (text_grid.gameObject.activeSelf)
        {
            grid_2d.gameObject.SetActive(true);
        }

        if (text_preFrontBack.gameObject.activeSelf)
        {
            frontBack.gameObject.SetActive(false);
        }
        else if (text_frontBack.gameObject.activeSelf)
        {
            frontBack.gameObject.SetActive(true);
        }

        if (text_circles.gameObject.activeSelf)
        {
            player.gameObject.SetActive(true);
            if (target != null)
            {
                target.gameObject.SetActive(true);
            }
        }

        if (text_target_2.gameObject.activeSelf)
        {
            target_2.gameObject.SetActive(true);
        }
    }
}
