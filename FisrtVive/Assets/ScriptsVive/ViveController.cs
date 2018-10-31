using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveController : MonoBehaviour {


    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            if(Controller.GetAxis()!=Vector2.zero)
            {
                Debug.Log(Controller.GetAxis());
            }
        }
	}
}
