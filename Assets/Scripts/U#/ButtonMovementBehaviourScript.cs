
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ButtonMovementBehaviourScript : UdonSharpBehaviour
{ 
    public float upperRestriction = 0.87f;
    public float lowerRestriction = 0.58f;
    private Vector3 initialPositionButton;

    void Start()
    {
        initialPositionButton = transform.position;
    }

    void Update()
    {
        float yPosition = transform.position.y;
        if (yPosition > upperRestriction)
        {
            yPosition = upperRestriction;
        }
        else if (yPosition < lowerRestriction) 
        {
            yPosition = lowerRestriction;
        }
        transform.position = new Vector3(initialPositionButton.x, yPosition, initialPositionButton.z);
    }

}
