namespace CustomJSONData.CustomBeatmap
{
    public class CustomNoteData : NoteData
    {
        /*public CustomNoteData(float time, int lineIndex, NoteLineLayer noteLineLayer, NoteLineLayer startNoteLineLayer, ColorType colorType, NoteCutDirection cutDirection,
                              float timeToNextBasicNote, float timeToPrevBasicNote, dynamic customData)
                       : base(time, lineIndex, noteLineLayer, startNoteLineLayer, colorType, cutDirection, timeToNextBasicNote, timeToPrevBasicNote, duration)
        {
            this.customData = customData;
        }
        */

        public CustomNoteData(float time, int lineIndex, NoteLineLayer noteLineLayer, NoteLineLayer startNoteLineLayer, ColorType colorType, NoteCutDirection cutDirection,
                              float timeToNextBasicNote, float timeToPrevBasicNote, int flipLineIndex, float flipYSide, float duration, dynamic customData)
                       : base(time, lineIndex, noteLineLayer, startNoteLineLayer, colorType, cutDirection, timeToNextBasicNote, timeToPrevBasicNote, flipLineIndex, flipYSide, duration)
        {
            this.customData = customData;
        }

        public dynamic customData { get; private set; }

        public override BeatmapObjectData GetCopy()
        {
            return new CustomNoteData(time, lineIndex, noteLineLayer, startNoteLineLayer, colorType, cutDirection, timeToNextColorNote, timeToPrevColorNote, flipLineIndex, flipYSide, duration, Trees.copy(customData));
        }
    }
}
