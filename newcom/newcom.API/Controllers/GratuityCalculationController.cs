using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newcom.DTO;
using Newcom.Service;

namespace Newcom.API
{
    [Route("api/[controller]")]
    public class GratuityCalculationController : Controller
    {
        private GratuityCalculationService _gratuityCalculationService;

        public GratuityCalculationController()
        {
            _gratuityCalculationService = new GratuityCalculationService();
        }

        [HttpGet]
        public List<GratuityCalculation> GetGratuityCalculations()
        {
            return _gratuityCalculationService.GetGratuityCalculations();
        }

        [HttpGet("{id}")]
        public GratuityCalculation GetGratuityCalculationById(int id)
        {
            return _gratuityCalculationService.GetGratuityCalculationById(id);
        }

        [HttpPost]
        public int CreateGratuityCalculation(GratuityCalculation obj)
        {
            return _gratuityCalculationService.CreateGratuityCalculation(obj);
        }

        [HttpPut]
        public bool UpdateGratuityCalculation(GratuityCalculation obj)
        {
            return _gratuityCalculationService.UpdateGratuityCalculation(obj);
        }

        [HttpDelete("{id}")]
        public bool DeleteGratuityCalculation(int id)
        {
            return _gratuityCalculationService.DeleteGratuityCalculation(id);
        }
    }
}