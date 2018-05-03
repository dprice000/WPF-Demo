using Demo.DAL;
using Demo.DAL.Models;
using System;
using System.Linq;

namespace Demo.DAL.Services
{
    public class MeasurementService
    {
        private LIMSContext dbContext;

        public MeasurementService()
        {
            this.dbContext = new LIMSContext();
        }

        public void Create(Measurement measurement)
        {
            this.dbContext.Measurements.Add(measurement);
            this.dbContext.SaveChanges();
        }

        public Measurement Get(Guid ID)
        {
            return this.dbContext.Measurements.Find(ID);
        }

        public void Update(Measurement measurment)
        {
            this.dbContext.Measurements.Attach(measurment);
            this.dbContext.SaveChanges();
        }

        public void Delete(Guid ID)
        {
            var meas = this.dbContext.Measurements.Find(ID);
            this.dbContext.Measurements.Remove(meas);
        }

        public void Delete(Measurement measurement)
        {
            this.dbContext.Measurements.Remove(measurement);
        }
    }
}
