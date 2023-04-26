using System;
using Newcom.DTO;

namespace Newcom
{
    public class GratuityCalculationRepository
    {
        public int Create(GratuityCalculation obj)
        {
            try
            {
                //Write your code here to insert obj into database
                return obj.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GratuityCalculation GetById(int id)
        {
            try
            {
                //Write your code here to fetch obj from database by id
                return new GratuityCalculation();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Update(GratuityCalculation obj)
        {
            try
            {
                //Write your code here to update obj in database
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                //Write your code here to delete obj from database by id
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}