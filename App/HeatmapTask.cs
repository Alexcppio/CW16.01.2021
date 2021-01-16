using System;

namespace Names
{
    internal static class HeatmapTask
    {

        public static string[] CreateLabels(int start, int end)
        {
            var result = new string[end - start + 1];
            for(int i = start; i <= end; ++i)
            {
                result[i - start] = i.ToString();
            }
            return result;
        }

        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var labelsX = CreateLabels(2, 31);
            var labelsY = CreateLabels(1, 12);

            var data = new double[30, 12];
            foreach (var nameData in names)
            {
                if (nameData.BirthDate.Day != 1)
                {
                    data[nameData.BirthDate.Day - 2, nameData.BirthDate.Month - 1]++;
                }
            }

            return new HeatmapData(
                "Пример карты интенсивностей",
                data, 
                labelsX, 
                labelsY);
        }
    }
}