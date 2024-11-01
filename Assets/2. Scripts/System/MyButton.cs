using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    public GameObject destroyLockImage;
    public void GetStarlightSkill()
    {
        Destroy(destroyLockImage);
    }
    public void DamageButton()
    {
        GameManager.Instance.slime.damage++;
    }

    public void HpButton()
    {
        GameManager.Instance.slime.hp += 5;
    }

    public void HpRecoveryButton()
    {
        GameManager.Instance.slime.hpRecovery += 0.6f;
    }

    public void CriticalButton()
    {
        GameManager.Instance.slime.critical++;
    }

    public void CriticalDamageButton()
    {
        GameManager.Instance.slime.criticalDamage++;
    }

    public void AttakSpeedButton()
    {
        GameManager.Instance.slime.attackSpeed += 0.1f;
    }

    public void DoubleShotButton()
    {
        GameManager.Instance.slime.doubleShot++;
    }
}
