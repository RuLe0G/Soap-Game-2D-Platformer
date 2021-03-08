using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScr : WeaponScr
{
    public Transform Firepoint;
    public int MyMag;
    public int MyAmmo;
    public void Start()
    {
        MyMag = Magazine;
        MyAmmo = Ammo;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Pew();
        }
    }

    public override void Pew()
    {

        if (MyMag > 0)
        {
            MyMag -= 1;
            Instantiate(bulets[0], Firepoint.position, Firepoint.rotation);

        }
        else Reload();

    }

    public override void Reload()
    {
        //MyAmmo - всего патрон есть
        //Magazine - макс патрон в мгазине
        //MyMag - магазин этого оружия
        //tempammo - temp
        //
        if (MyAmmo >= Magazine)
        {
            MyAmmo -= Magazine - MyMag;
            MyMag += Magazine - MyMag;
        }
        else
        {
            int temp = MyAmmo + MyMag;
            if (temp > Magazine)
            {
                int temptemp = temp - Magazine;
                MyAmmo = temptemp;
                MyMag = temp - temptemp;
            }
            else
            {
                MyMag = temp;
                MyAmmo = 0;
            }


        }

    }

    public override void Alt_Pew()
    {
        //
    }
}
