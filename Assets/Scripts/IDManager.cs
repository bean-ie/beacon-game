using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IDManager
{
    public static Dictionary<string, Type> activeAbilities = new Dictionary<string, Type>()
    {
        { "testAbility1", typeof(TestAbility1) }
    };
}
