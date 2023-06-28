using UnityEditor;

[CustomEditor(typeof(ElementScriptable))]
public class ElementSetupEditor : Editor
{
    #region SerializedProperties

    SerializedProperty elementName;

    SerializedProperty elementStrongAgainst;
    SerializedProperty elementWeakAgainst;

    SerializedProperty statusToInflict;
    SerializedProperty chancesToInflict;

    bool statusToInflictGroup = false;
    #endregion

    #region Editor Methods
    private void OnEnable()
    {
        elementName = serializedObject.FindProperty("elementName");

        elementStrongAgainst = serializedObject.FindProperty("elementStrongAgainst");
        elementWeakAgainst = serializedObject.FindProperty("elementWeakAgainst");

        statusToInflict = serializedObject.FindProperty("statusToInflict");
        chancesToInflict = serializedObject.FindProperty("chancesToInflict");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        UpdateValues();

        serializedObject.ApplyModifiedProperties();
    }

    private void UpdateValues()
    {
        EditorGUILayout.PropertyField(elementName);

        EditorGUILayout.PropertyField(elementStrongAgainst);
        EditorGUILayout.PropertyField(elementWeakAgainst);


        statusToInflictGroup = EditorGUILayout.BeginFoldoutHeaderGroup(statusToInflictGroup, "Status Settings");
        if (statusToInflictGroup)
        {
            EditorGUILayout.PropertyField(statusToInflict);
            EditorGUILayout.PropertyField(chancesToInflict);
        }
        EditorGUILayout.EndFoldoutHeaderGroup();
    }
    #endregion
}
