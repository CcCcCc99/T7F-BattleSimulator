using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualValues
{
    BitArray set_iv = new BitArray(30);

    public int Hp { get { return convert5BitToInt(getIvFromArray(29, set_iv)); } }
    public int Att { get { return convert5BitToInt(getIvFromArray(24, set_iv)); } }
    public int Def { get { return convert5BitToInt(getIvFromArray(19, set_iv)); } }
    public int SpAtt { get { return convert5BitToInt(getIvFromArray(14, set_iv)); } }
    public int SpDef { get { return convert5BitToInt(getIvFromArray(9, set_iv)); } }
    public int Spe { get { return convert5BitToInt(getIvFromArray(4, set_iv)); } }

    BitArray getIvFromArray(int startPoint, BitArray set) 
    {
        BitArray iv_arr = new BitArray(5);
        for (int i = 0; i < 5; i++)
            iv_arr.Set(4-i, set.Get(startPoint-i));
        return iv_arr;
    }

    int convert5BitToInt(BitArray arr) 
    {
        int num = 0;
        for (int i = 0; i < 5; i++)
            num += Convert.ToInt32(Math.Pow(2, i)) * Convert.ToInt32(arr.Get(i));
        return num;
    }
}
