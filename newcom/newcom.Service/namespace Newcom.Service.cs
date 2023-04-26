using System;
using Newcom.DTO;
using Newcom.DataAccess;

namespace Newcom.Service
{
    public class GratuityCalculationService
    {
        private GratuityCalculationRepository _gratuityCalculationRepository;

        public GratuityCalculationService()
        {
            _gratuityCalculationRepository = new GratuityCalculationRepository();
        }

        public int CreateGratuityCalculation(GratuityCalculation obj)
        {
            try
            {
                return _gratuityCalculationRepository.Create(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GratuityCalculation GetGratuityCalculationById(int id)
        {
            try
            {
                return _gratuityCalculationRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdateGratuityCalculation(GratuityCalculation obj)
        {
            try
            {
                return _gratuityCalculationRepository.Update(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DeleteGratuityCalculation(int id)
        {
            try
            {
                return _gratuityCalculationRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}