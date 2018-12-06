using UnityEngine;
using System.Collections;

public class InheritedGrenade : vp_Grenade {
	private vp_Timer.Handle Timer = new vp_Timer.Handle();
	void OnDestroy(){
		Timer.Cancel();
	}
	void Start () {
		vp_Timer.In(LifeTime, delegate()
			{
				transform.SendMessage("DieBySources", new Transform[]{m_Source, m_OriginalSource}, SendMessageOptions.DontRequireReceiver);
			},Timer);
	}
}