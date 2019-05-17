using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticTouch : MonoBehaviour {


    public bool hapticFlag = false;
    private SteamVR_TrackedObjecttrackerObject;
        private SteamVR_Controller.Device device;

   void Start()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    void Update()

    {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if(hapticFlag)
        {
            device.TriggerHapticPulse(600);
    }
}
		void OnTriggerEnter () {
        hapticFlag = true;
	}
    private void OnTriggerExit()
    {
        hapticFlag = false;
    }
}
