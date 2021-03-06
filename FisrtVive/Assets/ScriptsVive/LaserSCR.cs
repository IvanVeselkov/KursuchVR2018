﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSCR : MonoBehaviour {

    public GameObject laserPrefab;

    private GameObject laser;

    private Transform laserTransform;

    private Vector3 hitPoint;

    public Transform cameraRigTransform;

    public GameObject teleportReticlePrefab;

    private GameObject reticle;

    private Transform teleportReticleTransform;

    public Transform headTransform;

    public Vector3 teleportReticleOffset;

    public LayerMask walkable, notWalkable;

    private bool shouldTeleport; 

    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
     get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	void Start () 
    {

        laser = Instantiate(laserPrefab);

        laserTransform = laser.transform;

        reticle = Instantiate(teleportReticlePrefab);

        teleportReticleTransform = reticle.transform;
	}
	
	
	void Update () 
    {
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            RaycastHit hit;

            if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 2, walkable))
            {
                hitPoint = hit.point;
                ShowLaser(hit);
                reticle.SetActive(true);

                teleportReticleTransform.position = hitPoint + teleportReticleOffset;

                shouldTeleport = true;
            }
            else if(Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 2, notWalkable)){
                reticle.SetActive(false);
                shouldTeleport = false;
            }
        }
        else 
        {
            laser.SetActive(false);
        }
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad) && shouldTeleport)
        {
            Teleport();
        }
	}

    private void ShowLaser(RaycastHit hit)
    {

        laser.SetActive(true);

        reticle.SetActive(false);

        laserTransform.position = Vector3.Lerp(trackedObj.transform.position, hitPoint, .5f);

        laserTransform.LookAt(hitPoint);

        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y,
            hit.distance);

    }

    private void Teleport()
    {
         shouldTeleport = false;

         reticle.SetActive(false);

         Vector3 difference = cameraRigTransform.position - headTransform.position;

         difference.y = 0;

         cameraRigTransform.position = hitPoint + difference;
    }
}
