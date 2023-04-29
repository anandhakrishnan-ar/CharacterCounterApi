using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CharacterCounterApi.Abstract
{
    public interface ICounterEntity
    {
        Task<Dictionary<char, int>> GetCharacterCount(string characters);
    }
}
