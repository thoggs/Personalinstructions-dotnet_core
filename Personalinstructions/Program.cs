using System;
using Personalinstructions.ContentContext;
using Personalinstructions.ContentContext.Enums;

namespace Personalinstructions
{
    internal static class Program
    {
        private static void Main()
        {
            var course = new Course {Level = EContentLevel.Beginner};
        }
    }
}