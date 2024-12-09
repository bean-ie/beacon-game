using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbility1 : ActiveAbility
{
    public TestAbility1()
    {
        abilityName = "Test Ability 1";
        abilityDescription = "Does something";
        cooldown = 2f;
    }

    public override void UseAbility()
    {

    }
}
