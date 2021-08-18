using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    public static void FromMatrix(this Transform transform, Matrix4x4 matrix)
    {
        transform.SetGlobalScale(matrix.ExtractScale());
        transform.rotation = matrix.ExtractRotation();
        transform.position = matrix.ExtractPosition();
    }
    public static void SetGlobalScale(this Transform transform, Vector3 globalScale)
    {
        transform.localScale = Vector3.one;
        transform.localScale = new Vector3(globalScale.x / transform.lossyScale.x, globalScale.y / transform.lossyScale.y, globalScale.z / transform.lossyScale.z);
    }
}



public static class MatrixExtensions
{
    public static Quaternion ExtractRotation(this Matrix4x4 matrix)
    {
        Vector3 forward;
        forward.x = matrix.m02;
        forward.y = matrix.m12;
        forward.z = matrix.m22;

        Vector3 upwards;
        upwards.x = matrix.m01;
        upwards.y = matrix.m11;
        upwards.z = matrix.m21;

        return Quaternion.LookRotation(forward, upwards);
    }

    public static Vector3 ExtractPosition(this Matrix4x4 matrix)
    {
        Vector3 position;
        position.x = matrix.m03;
        position.y = matrix.m13;
        position.z = matrix.m23;
        return position;
    }

    public static Vector3 ExtractScale(this Matrix4x4 matrix)
    {
        Vector3 scale;
        scale.x = new Vector4(matrix.m00, matrix.m10, matrix.m20, matrix.m30).magnitude;
        scale.y = new Vector4(matrix.m01, matrix.m11, matrix.m21, matrix.m31).magnitude;
        scale.z = new Vector4(matrix.m02, matrix.m12, matrix.m22, matrix.m32).magnitude;
        return scale;
    }
}

public class ObjectPickup : MonoBehaviour
{


    //[SerializeField]
    //private GameObject hoveredObject;
    //[SerializeField]
    //private GameObject grabbedObject;

    [SerializeField]
    private PickupableObject hoveredObject;
    //private Transform oldParent;
    //bool grabbed = false;

    public FixedJoint fJoint;
    public MeshRenderer indicator;

    public bool grabbing = false;
    public ObjectPickup otherHand = null;
    PickupableObject grabbedObject = null;
    //public Collider collider;
    //public MeshRenderer indicator;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PickupableObject>() != null)
        {
            hoveredObject = other.GetComponent<PickupableObject>();
            // Change the cube color to green.
            MeshRenderer meshRend = indicator;
            meshRend.material.color = Color.green;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        hoveredObject = null;
        // Revert the cube color to white.
        MeshRenderer meshRend = indicator;
        meshRend.material.color = Color.white;

    }
    public void Squeeze(Valve.VR.SteamVR_Behaviour_Single b, Valve.VR.SteamVR_Input_Sources s, float f, float f2)
    {
        if (f < 0.5)
            DropObject();

        if (f >= 0.5)
            PickupObject();
    }


    float lastDist = 0;
    float intitialDist;
    Vector3 intitialScale;

    public bool scaling = false;

    //public void ScaleAround(GameObject target, Vector3 pivot, Vector3 newScale)
    //{
    //    Vector3 A = target.transform.localPosition;
    //    Vector3 B = pivot;

    //    Vector3 C = A - B; // diff from object pivot to desired pivot/origin

    //    float RS = newScale.x / target.transform.localScale.x; // relataive scale factor

    //    // calc final position post-scale
    //    Vector3 FP = B + C * RS;

    //    // finally, actually perform the scale/translation
    //    target.transform.localScale = newScale;
    //    target.transform.localPosition = FP;
    //    Debug.Log(A*1000 + " | " + B*1000 + " | " + C*1000 + " | " + RS*1000 + " | " + target.transform.localPosition*1000);

    //}

    public void PickupObject()
    {
        Debug.Log("Picking up ");

        //if(hoveredObject != null && grabbedObject == null)
        //{
        //oldParent = hoveredObject.transform.parent;
        //hoveredObject.transform.SetParent(transform, true);
        //grabbedObject = hoveredObject;
        //}

        if (hoveredObject != null)
        {

            if(otherHand.grabbing == false)
            {
                //fJoint.connectedBody = obj.GetComponent<Rigidbody>();
                grabbing = true;
                grabbedObject = hoveredObject;

            } else
            {
                Debug.Log("You wanna scale?");
                scaling = true;
                lastDist = Vector3.Distance(transform.position, otherHand.transform.position);
                intitialDist = lastDist;
                intitialScale = hoveredObject.transform.localScale;
                lastAngle = hoveredObject.transform.rotation;

                float pDist = intitialDist / intitialDist;

                Vector3 averagePos = (this.transform.position + otherHand.transform.position) / 2;
                Vector3 between = otherHand.transform.position - this.transform.position;
                Vector3 averageUp = (this.transform.up + otherHand.transform.up) / 2;

                Vector3 averageForward = Vector3.Cross(between, averageUp);
                averageUp = -Vector3.Cross(between, averageForward);

                Quaternion averageRot = Quaternion.LookRotation(averageForward, averageUp);
                float sharedScale = intitialScale.x * pDist;

                lastMidMat = Matrix4x4.TRS(averagePos, averageRot, sharedScale * Vector3.one);


            }

        }
        else
        {
            //fJoint.connectedBody = null;
        }

    }
    Matrix4x4 lastMidMat;
    Vector3 lastHandDifference;
    Quaternion lastAngle;
    // Update is called once per frame

    Matrix4x4 grabOffset;

    Matrix4x4 lastMatrix;
    void Update()
    {



        Matrix4x4 deltaMatrix;

        Vector3 currentHandDifference = transform.position - otherHand.transform.position;
        float currentDist = Vector3.Magnitude(currentHandDifference);

        float distDelta = currentDist - lastDist;
        Quaternion rotDelta = Quaternion.FromToRotation(lastHandDifference, currentHandDifference);


        lastDist = currentDist;
        lastHandDifference = currentHandDifference;


        if( grabbing && grabbedObject != null && otherHand.scaling == false)
        {
            Matrix4x4 currentMatrix = this.transform.localToWorldMatrix;
            deltaMatrix =  currentMatrix * lastMatrix.inverse;
            lastMatrix = currentMatrix;

            Matrix4x4 newObjMat = deltaMatrix * grabbedObject.transform.localToWorldMatrix;
            grabbedObject.transform.FromMatrix(newObjMat);
            
        }
        lastMatrix = this.transform.localToWorldMatrix;
        if (scaling)
        {

            float pDist = currentDist / intitialDist;

            Vector3 averagePos = (this.transform.position + otherHand.transform.position)/2;
            Vector3 between = otherHand.transform.position - this.transform.position;
            Vector3 averageUp = (this.transform.up + otherHand.transform.up) / 2;

            Vector3 averageForward = Vector3.Cross(between, averageUp);
            averageUp = -Vector3.Cross(between, averageForward);

            Quaternion averageRot = Quaternion.LookRotation(averageForward,averageUp);
            float sharedScale = intitialScale.x * pDist;

            Matrix4x4 currentMidMat = Matrix4x4.TRS(averagePos, averageRot, sharedScale*Vector3.one);
            deltaMatrix = currentMidMat * lastMidMat.inverse;

            lastMidMat = currentMidMat;

            Matrix4x4 newObjMat = deltaMatrix * otherHand.grabbedObject.transform.localToWorldMatrix;
            otherHand.grabbedObject.transform.FromMatrix(newObjMat);

            //Quaternion currentAngle = hoveredObject.transform.localRotation;


      

            //var temp = otherHand.fJoint.connectedBody;
            //otherHand.fJoint.connectedBody = null;



            //ScaleAround(hoveredObject.gameObject, otherHand. transform.position, intitialScale * pDist);
            //float angle = 0;
            //Vector3 axis;
            //rotDelta.ToAngleAxis(out angle, out axis);
            //hoveredObject.transform.rotation = lastAngle;
            //hoveredObject.transform.RotateAround(otherHand.transform.position, axis,angle);
            //otherHand.fJoint.connectedBody = temp;

            //lastAngle = hoveredObject.transform.rotation;


        }



    }

    public void DropObject()
    {

        //if(grabbedObject != null)
        //    grabbedObject.transform.SetParent(oldParent, true);
        //grabbedObject = null;
        grabbedObject = null;
        if(otherHand.scaling == true)
        {
            otherHand.PickupObject();
        }

        grabbing = false;
        scaling = false;


    }

}
