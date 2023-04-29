using CharacterCounterApi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCounterApi.Domain
{
    public class CounterEntity : ICounterEntity
    {
        #region PUBLIC METHODS
        public async Task<Dictionary<char, int>> GetCharacterCount(string characters)
        {
            return characters?.ToUpper()
                .Replace(" ", "")
                .GroupBy(x => x)
                .Select(x => new KeyValuePair<char, int>(x.Key, x.Count()))
                .ToDictionary(x => x.Key, x => x.Value);
        }
        #endregion
    }
}
