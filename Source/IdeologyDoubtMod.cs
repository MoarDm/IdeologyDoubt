using System;
using System.Reflection;
using Verse;
using RimWorld;

namespace IdeologyDoubt
{
    [StaticConstructorOnStartup]
    public static class IdeologyDoubtMod
    {

        static IdeologyDoubtMod()
        {
            
            SimpleCurve patchedCurve = new SimpleCurve
            {
                new CurvePoint(0f  , -0.05f),
                new CurvePoint(0.1f, -0.03f),
                new CurvePoint(0.2f,  0f),
                new CurvePoint(0.5f,  0.02f),
                new CurvePoint(0.8f,  0.03f)
            };
            FieldInfo field = typeof(ConversionTuning).GetField("CertaintyPerDayByMoodCurve", BindingFlags.Public | BindingFlags.Static);
            field.SetValue(null, patchedCurve);

            Log.Message("IdeologyDoubtMod loaded");
        }
    }
}
