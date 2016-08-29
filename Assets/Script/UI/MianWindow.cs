﻿using UnityEngine;
using System.Collections;

public class MianWindow : UIWindowBase 
{
    public override IEnumerator EnterAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    {
        AnimSystem.uguiAlpha(gameObject, 0, 1, 1, InteType.Linear, true,(object[] obj)=>
        {
            base.EnterAnim(l_animComplete, l_callBack, objs);
        });

        return null;
    }

    public override IEnumerator ExitAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    {
        AnimSystem.uguiAlpha(gameObject, 1, 0, 1, InteType.Linear, true, (object[] obj) =>
        {
            base.ExitAnim(l_animComplete, l_callBack, objs);
        });

        return null;
    }

    public override void OnInit()
    {
        base.OnInit();
    }


    public override void OnRefresh()
    {
        base.OnRefresh();
    }
}
