using System;
namespace Givemin5.TennisGameTests
{
    using JetBrains.Annotations;
    public static class SourceTemplates
        {
            [SourceTemplate]
            [Macro(Target = "expected", Editable = 1)]
            public static void ae<T>(this T source)
            {
                /*$ Assert.AreEqual( $expected$ , source);*/
            }

            [SourceTemplate]
            public static void abs<T>(this T source)
            {
                /*$ Math.Abs(source)*/
            }
        }
}
