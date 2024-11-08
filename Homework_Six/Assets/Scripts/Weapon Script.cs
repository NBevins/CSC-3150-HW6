using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float shootRange = 100f;
    [SerializeField] ParticleSystem muzzleFlash;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    private void PlayMuzzleFlash(){
        muzzleFlash.Play();
    }

    private void Shoot(){
        PlayMuzzleFlash();
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, shootRange)){
            Debug.Log("I hit an object " + hit.transform.name);
        }
        else{
            return;
        }

    }
}
