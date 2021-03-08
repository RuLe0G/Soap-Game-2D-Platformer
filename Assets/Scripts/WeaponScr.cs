using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class WeaponScr : MonoBehaviour
{
    public GameObject[] bulets; //ссылка на префаб пули
    public int Ammo;    //кол-во пуль всего
    public int Magazine;    //кол-во пуль в магазине    
    public string AmmoType; //типа расходуемого боеприпаса(дробь, 9мм, 5.6 ...)

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Pew();
        if (Input.GetKeyDown(KeyCode.R))
            Reload();
        if (Input.GetKeyDown(KeyCode.Mouse2))
            Alt_Pew();
    }

    public abstract void Pew();
    public abstract void Reload();
    public abstract void Alt_Pew();

}
