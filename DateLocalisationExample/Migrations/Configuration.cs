namespace DateLocalisationExample.Migrations
{
    using DateExample.DataModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DateExample.DataModel.Week11Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DateExample.DataModel.Week11Context context)
        {

            context.Dates.AddOrUpdate(new LocalDate[] {
            new LocalDate
            {
               StartDate = new DateTime(day:25,month:05,year:2022),
                EndDate = new DateTime(day:26,month:05,year:2022),

            },
            });
        }
    }
}
