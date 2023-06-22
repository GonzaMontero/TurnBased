using UnityEditor;

[CustomEditor(typeof(SpecialMoveScriptable))]
public class SpecialMoveSetupEditor : Editor
{
    #region SerializedProperties

    SerializedProperty element;

    SerializedProperty moveName;

    SerializedProperty moveDamage;
    SerializedProperty moveAccuracy;

    SerializedProperty moveHasSecondaryEffects;

    SerializedProperty moveHasRecoil;
    SerializedProperty moveRecoilPercentage;

    SerializedProperty moveLowersPlayerStat;
    SerializedProperty statToLowerPlayer;
    SerializedProperty stagesToReducePlayerStat;

    SerializedProperty moveLowersEnemyStat;
    SerializedProperty statToLowerEnemy;
    SerializedProperty stagesToReduceEnemyStat;

    bool moveBaseGroup = false;
    bool moveRecoilGroup = false;
    bool movePlayerStatChangeGroup = false;
    bool moveEnemyStatChangeGroup = false;
    #endregion

    #region Editor Methods
    private void OnEnable()
    {
        element = serializedObject.FindProperty("public");

        moveName = serializedObject.FindProperty("moveName");

        moveDamage = serializedObject.FindProperty("moveDamage");
        moveAccuracy = serializedObject.FindProperty("moveAccuracy");

        moveHasSecondaryEffects = serializedObject.FindProperty("moveHasSecondaryEffects");

        moveHasRecoil = serializedObject.FindProperty("moveHasRecoil");
        moveRecoilPercentage = serializedObject.FindProperty("moveRecoilPercentage");

        moveLowersPlayerStat = serializedObject.FindProperty("moveLowersPlayerStat");
        statToLowerPlayer = serializedObject.FindProperty("statToLowerPlayer");
        stagesToReducePlayerStat = serializedObject.FindProperty("stagesToReducePlayerStat");

        moveLowersEnemyStat = serializedObject.FindProperty("moveLowersEnemyStat");
        statToLowerEnemy = serializedObject.FindProperty("statToLowerEnemy");
        stagesToReduceEnemyStat = serializedObject.FindProperty("stagesToReduceEnemyStat");
    }

    public override void OnInspectorGUI()
    {
        SpecialMoveScriptable _specialMoveScriptable = (SpecialMoveScriptable)target;

        serializedObject.Update();

        UpdateValues(_specialMoveScriptable);

        serializedObject.ApplyModifiedProperties();
    }

    private void UpdateValues(SpecialMoveScriptable _specialMoveScriptable)
    {
        EditorGUILayout.PropertyField(element);

        moveBaseGroup = EditorGUILayout.BeginFoldoutHeaderGroup(moveBaseGroup, "Base Move Settings");
        if (moveBaseGroup)
        {
            EditorGUILayout.PropertyField(moveName);
            EditorGUILayout.PropertyField(moveDamage);
            EditorGUILayout.PropertyField(moveAccuracy);
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        EditorGUILayout.PropertyField(moveHasSecondaryEffects);

        if (_specialMoveScriptable.moveHasSecondaryEffects)
        {
            moveRecoilGroup = EditorGUILayout.BeginFoldoutHeaderGroup(moveRecoilGroup, "Move Recoil Settings");
            if (moveRecoilGroup)
            {
                EditorGUILayout.PropertyField(moveHasRecoil);

                if (_specialMoveScriptable.moveHasRecoil)
                    EditorGUILayout.PropertyField(moveRecoilPercentage);
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            movePlayerStatChangeGroup = EditorGUILayout.BeginFoldoutHeaderGroup(movePlayerStatChangeGroup, "Player Stat Changes Settings");
            if (movePlayerStatChangeGroup)
            {
                EditorGUILayout.PropertyField(moveLowersPlayerStat);
                if (_specialMoveScriptable.moveLowersPlayerStat)
                {
                    EditorGUILayout.PropertyField(statToLowerPlayer);
                    EditorGUILayout.PropertyField(stagesToReducePlayerStat);
                }
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            moveEnemyStatChangeGroup = EditorGUILayout.BeginFoldoutHeaderGroup(moveEnemyStatChangeGroup, "Enemmy Stat Changes Settings");
            if (moveEnemyStatChangeGroup)
            {
                EditorGUILayout.PropertyField(moveLowersEnemyStat);
                if (_specialMoveScriptable.moveLowersEnemyStat)
                {
                    EditorGUILayout.PropertyField(statToLowerEnemy);
                    EditorGUILayout.PropertyField(stagesToReduceEnemyStat);
                }
            }
            EditorGUILayout.EndFoldoutHeaderGroup();
        }
    }
    #endregion
}
