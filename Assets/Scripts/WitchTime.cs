using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    private bool IsSlowed = false;
    public float DurationSlowMotion = 1f;
    public float HowSlow = 0.25f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SlowMotion();
            IsSlowed = true;
        }
        else
        {

            IsSlowed = false;
        }
    }
    private IEnumerator SlowMotion()
    {
      
        Time.timeScale = DurationSlowMotion;
        yield return new WaitForSeconds(DurationSlowMotion);
        
    }
}
