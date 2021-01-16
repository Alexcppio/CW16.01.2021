using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var labels = new string[31];
            for(int i = 1; i <= 31; ++i)
            {
                labels[i - 1] = i.ToString();
            }

            var result = new double[31];

            foreach (var nameData in names)
            {
                if (nameData.Name == name && nameData.BirthDate.Day != 1)
                {
                    result[nameData.BirthDate.Day - 1]++;
                }
            }

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                labels, 
                result);
        }
    }
}