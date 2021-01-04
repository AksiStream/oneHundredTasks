using System;

namespace oneHundredTasks.CharacterLevelingOOP
{
    public class Skill
    {
        public Skill(string name)
        {
            Name = name;
            Value = 0;
        }

        public string Name { get; }
        public int Value { get; private set; }

        public int ChangeValue(int delta, string operation)
        {
            var oldValue = Value;
            Value = operation == "-" ? Clamp(Value - delta, 0, 10) : Clamp(Value + delta, 0, 10);
            return oldValue - Value;
        }

        private static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            if (val.CompareTo(max) > 0) return max;
            return val;
        }
    }
}