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
        [SourceTemplate]
        public static void cc<T>(this T source)
        {
            /*$ source;
                source
             */
        }
        [SourceTemplate]
        [Macro(Target = "parameter", Editable = 1)]
        public static void forloop<T>(this T source)
        {
            /*$ for (int i = 0; i< $parameter$; i++)
            {
                source;
            }
            */
        }
    }
}
