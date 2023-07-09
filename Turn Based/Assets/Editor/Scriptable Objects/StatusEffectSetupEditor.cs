using UnityEditor;

[CustomEditor(typeof(StatusEffectScriptable))]
public class StatusEffectSetupEditor : Editor
{
    #region SerializedProperties

    SerializedProperty statusKey;

    SerializedProperty statusLowersStat;
    SerializedProperty statToLower;
    SerializedProperty stagesToLower;

    SerializedProperty lowersHealthPerTurn;
    SerializedProperty healthPercentageToLower;

    bool lowersStatGroup = false;
    bool lowersHealthGroup = false;
    #endregion

    #region Editor Methods
    private void OnEnable()
    {
        statusKey = serializedObject.FindProperty("statusKey");

        statusLowersStat = serializedObject.FindProperty("statusLowersStat");
        statToLower = serializedObject.FindProperty("statToLower");
        stagesToLower = serializedObject.FindProperty("stagesToLower");

        lowersHealthPerTurn = serializedObject.FindProperty("lowersHealthPerTurn");
        healthPercentageToLower = serializedObject.FindProperty("healthPercentageToLower");
    }

    public override void OnInspectorGUI()
    {
        StatusEffectScriptable _statusEffectScriptable = (StatusEffectScriptable)target;

        serializedObject.Update();

        UpdateValues(_statusEffectScriptable);

        serializedObject.ApplyModifiedProperties();
    }

    private void UpdateValues(StatusEffectScriptable _statusEffectScriptable)
    {
        EditorGUILayout.PropertyField(statusKey);

        lowersStatGroup = EditorGUILayout.BeginFoldoutHeaderGroup(lowersStatGroup, "Stat To Lower Settings");
        if (lowersStatGroup)
        {
            EditorGUILayout.PropertyField(statusLowersStat);

            if (_statusEffectScriptable.statusLowersStat)
            {
                EditorGUILayout.PropertyField(statToLower);
                EditorGUILayout.PropertyField(stagesToLower);
            }
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        lowersHealthGroup = EditorGUILayout.BeginFoldoutHeaderGroup(lowersHealthGroup, "Health To Lower Settings");
        if (lowersHealthGroup)
        {
            EditorGUILayout.PropertyField(lowersHealthPerTurn);

            if (_statusEffectScriptable.lowersHealthPerTurn)
            {
                EditorGUILayout.PropertyField(healthPercentageToLower);
            }
        }
        EditorGUILayout.EndFoldoutHeaderGroup();
        }    
    #endregion
}

