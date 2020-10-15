using static CustomJSONData.Trees;

namespace CustomJSONData.CustomBeatmap
{
    public class CustomBeatmapData : BeatmapData
    {
        public CustomEventData[] customEventData { get; }
        public dynamic customData { get; }
        public dynamic beatmapCustomData { get; }
        public dynamic levelCustomData { get; }

        public CustomBeatmapData(BeatmapData data, CustomEventData[] customEventData, dynamic customData, dynamic beatmapCustomData, dynamic levelCustomData)
                          : base(200)
        {
            base.CopyBeatmapEvents(data, this);
            base.CopyBeatmapObjects(data, this);
            this.customData = customData;
            this.customEventData = customEventData;
            this.beatmapCustomData = beatmapCustomData;
            this.levelCustomData = levelCustomData;
        }

        public new BeatmapData GetCopy()
        {
            CustomEventData[] customEventDataCopy = GetCustomEventDataCopy();
            return new CustomBeatmapData(base.GetCopy(), customEventDataCopy, copy(customData), copy(beatmapCustomData), copy(levelCustomData));
        }

        private CustomEventData[] GetCustomEventDataCopy()
        {
            CustomEventData[] array = new CustomEventData[this.customEventData.Length];
            for (int i = 0; i < this.customEventData.Length; i++)
            {
                CustomEventData customEventData = this.customEventData[i];
                array[i] = customEventData;
            }
            return array;
        }
    }
}
