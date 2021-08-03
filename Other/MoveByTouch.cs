using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveByTouch : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    public Sprite HorizontalSprite;
    public Image background;

    void Start()
    {
        variableJoystick.AxisOptions = AxisOptions.Horizontal;
        background.sprite = HorizontalSprite;
    }
    // Update is called once per frame
    void Update()
    {
        if( Input.touchCount > 0 )
        {
            // Input.touches is an array of all touches
            for(int i = 0; i < Input.touchCount; i++)
            {
                Vector3 TouchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
                Debug.DrawLine(Vector3.zero, TouchPosition, Color.red);
            }
        }
    }
}
