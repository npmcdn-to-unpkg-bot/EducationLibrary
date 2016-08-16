using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using EducationLibrary.Entities;
using EducationLibrary.Api.Models;
using EducationLibrary.Abstract;


namespace EducationLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    public class PreviewController : Controller
    {
        private IMapper _mapper;
        private IPreviewService _service;
        public PreviewController(IMapper mapper, IPreviewService service)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<PreviewModel> Get()
        {
            var collections = _mapper.Map<IEnumerable<Preview>, List<PreviewModel>>(_service.GetAllPreviews());
            return collections;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public PreviewModel Get(int id)
        {
            Preview preview = _service.GetPreviewById(id);
            PreviewModel model = _mapper.Map<Preview, PreviewModel>(preview);
            return model;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]PreviewModel model)
        {
            if (ModelState.IsValid)
            {
                Preview preview = _mapper.Map<PreviewModel, Preview>(model);
                _service.InsertPreview(preview);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]PreviewModel model)
        {
            if (model != null)
            {
                var preview = _mapper.Map<PreviewModel, Preview>(model);
                _service.UpdatePreview(preview);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if(id != 0)
            {
                var model = _service.GetPreviewById(id);
                _service.DeletePreview(model);
            }
        }
    }
}
