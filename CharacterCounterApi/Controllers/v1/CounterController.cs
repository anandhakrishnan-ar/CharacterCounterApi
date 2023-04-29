using CharacterCounterApi.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCounterApi.Controllers.v1
{
    [Route("api/v1/counter")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        #region PRIVATE INSTANCE FIELDS
        private readonly ICounterEntity _counterEntity;

        #endregion

        #region CONSTRUCTOR
        public CounterController(ICounterEntity counterEntity)
        {
            _counterEntity = counterEntity;
        }

        #endregion

        #region PUBLIC METHODS
        [HttpGet]
        [Route("get-count")]
        public async Task<IActionResult> GetCharacterCount(string characters)
        {
            try
            {
                return Ok(await _counterEntity.GetCharacterCount(characters));
            }
            catch(Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
