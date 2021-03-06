using System;

namespace CrashCourse2020ExercisesDayFourUI
{
    public interface IMenuUtils
    {
        public void ReadIntegerFromString(string headline, out int choice);

        public void ReadMinimumLengthString(string headline, out string newString, int minimumLength);

        public void ReadDateFrom(string headline, out DateTime date);
    }
}