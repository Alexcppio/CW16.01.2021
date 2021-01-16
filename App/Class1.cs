using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class CreativityTask
    {
        public static HistogramData ShowYourStatistics(NameData[] names, string letter)
        {
            var labels = new string[31];
            for (int i = 1; i <= 31; ++i)
            {
                labels[i - 1] = i.ToString();
            }

            var alphavet = new string[33] { 'a', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и',
            'к', 'л'}

            var result = new double[31];

            foreach (var nameData in names)
            {
                if (nameData.Name.StartsWith(letter) && nameData.BirthDate.Day != 1)
                {
                    result[nameData.BirthDate.Day - 1]++;
                }
            }

            return new HistogramData(
                string.Format("Рождаемость людей с именем, начинающимся на букву '{0}'", letter),
                labels,
                result);
        }
    }
}
