using HarmonyLib;
using System.Collections.Generic;
using static CustomJSONData.HarmonyPatches.BeatDataTransformHelperHelper;

namespace CustomJSONData.HarmonyPatches
{
    [HarmonyPatch(typeof(BeatmapDataMirrorTransform))]
    [HarmonyPatch("CreateTransformedData")]
    internal class BeatDataMirrorTransformCreateTransformData
    {
        private static void Postfix(ref IReadonlyBeatmapData __result, BeatmapData beatmapData)
        {
            PostfixHelper(ref __result, beatmapData);
        }

        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            return TranspilerHelper(instructions);
        }
    }
}
