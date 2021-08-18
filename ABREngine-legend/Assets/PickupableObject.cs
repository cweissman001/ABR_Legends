using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickupableObject : MonoBehaviour
{

    Vector3 startPosition;
    Quaternion startRotation;
    float startScale;
    bool isResetting = false;
    double resetTimeLeft = 0;

    public bool forceResetNow = false;
    public void BeginResetOrientation()
    {
        isResetting = true;
        resetTimeLeft = 1;
        startScale = transform.localScale.x;
        startRotation = transform.localRotation;
        startPosition = transform.localPosition;
    }

    public void ResetOrientation()
    {
        this.transform.localPosition = Vector3.zero;
        this.transform.localRotation = Quaternion.identity;
        this.transform.localScale = Vector3.one;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(forceResetNow)
        {
            BeginResetOrientation();
            forceResetNow = false;
        }
        if(isResetting &&  resetTimeLeft < 0)
        {
            isResetting = false;
            resetTimeLeft = 0;
            ResetOrientation();

        } else if (isResetting)
        {
            transform.localPosition = Vector3.Lerp(Vector3.zero, startPosition, Easing.Quadratic.InOut((float)resetTimeLeft));
            transform.localScale = Vector3.Lerp(Vector3.one, startScale * Vector3.one, Easing.Quadratic.InOut((float)resetTimeLeft));
            transform.localRotation = Quaternion.Slerp(Quaternion.identity, startRotation, Easing.Quadratic.InOut((float)resetTimeLeft));
            resetTimeLeft -= Time.deltaTime;

  

        }

    }
}
