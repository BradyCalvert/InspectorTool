using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(DegRadAttribute))]
public class DegRadDrawer : PropertyDrawer {

    public const int row = 17;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {

        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.alignment = TextAnchor.MiddleCenter;
        Rect sliderPosition = position;
        sliderPosition.height = row;
        //0000000000000000

        property.floatValue = GUI.HorizontalSlider(sliderPosition, property.floatValue, 0.0f, 360.0F);

        Rect labelPos = position;
        labelPos.y += row;
        labelPos.height = row;
        labelPos.width = labelPos.width / 2;

        EditorGUI.LabelField(labelPos, property.floatValue.ToString("F2") + "*", myStyle);

        labelPos.x += labelPos.width;
        float rad = property.floatValue * Mathf.Deg2Rad;

        EditorGUI.LabelField(labelPos, rad.ToString("F2") + "rad",myStyle);
    }
}
