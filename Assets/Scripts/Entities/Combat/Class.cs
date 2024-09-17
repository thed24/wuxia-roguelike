using UnityEngine;

namespace Entities.Combat
{
    [CreateAssetMenu(fileName = "NewClass", menuName = "Class")]
    public class Class : ScriptableObject
    {
        public string Name;
        public string Description;
        public Skill PrimarySkill;
    }
}
