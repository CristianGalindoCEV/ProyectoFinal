using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
   //Armas
    [SerializeField] private GameObject Bauculo;
    [SerializeField] private GameObject Espada;
    public bool BauculoItem = false;
    public bool EspadaItem = true;
   
    //HUD
    public GameObject hud;
    public GameObject ingamemenu;
    public bool menuon;
    public GameMaster gamemaster;

    //Player
    private PlayerController player;

    //Cursor
    private bool m_islocked;


    // Start is called before the first frame update
    void Start()
    {
        Bauculo.SetActive(false);
        player = FindObjectOfType<PlayerController>();
        menuon = false;
        ingamemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Combate y armas
        if (BauculoItem == true)
        {
            Espada.SetActive(false);
            Bauculo.SetActive(true);
            EspadaItem = (false);
            if (Input.GetButtonDown("Fire1"))
            {
                //Bauculo.Fire();
            }
        }
        
        else if (EspadaItem == true)
        {
            Espada.SetActive(true);
            Bauculo.SetActive(false);
            BauculoItem = (false);
            if (Input.GetButtonDown("Fire1"))
            {
                //Espada.Fire();
            }
        }
        
        if (Input.GetKey("1"))
        {
            EspadaItem = true;
            BauculoItem = false;
        }
        
        if (Input.GetKey("2") && gamemaster.unlocked == true)
         {
            BauculoItem = true;
            EspadaItem = false;
         }
        //Salto
        //player.SetAxis(Input.GetAxis("Horizontal"));

        if (Input.GetButtonDown("Jump"))
            player.Jump();

        //Canvas
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if( menuon == false)
            {
                ingamemenu.SetActive(true);
                menuon = true;
            }else
            {
                ingamemenu.SetActive(false);
                menuon = false;
            }
        }
        
    }


}
