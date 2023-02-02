using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEH_NAV_Slip : BEH_Navigator
{

    // Update is called once per frame
    void Update()
    {
        float curSpd = entity ? entity.stats.move : 0;
        Vector2 curDir = Navigate();
        body.AddForce(curDir.normalized * curSpd, ForceMode2D.Force);
    }
}
