﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateExample.DataModel
{
    public class LocalDate
    {
        [Key]
        public int ID { get; set; }
        // [DataType(DataType.Date)] // Used for HTML 5 Browser enabled Date Control but does not 
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        //[DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate{ get; set; }
    }

    public class Week11Context : DbContext
    {
        public DbSet<LocalDate> Dates { get; set; }

        public Week11Context() : base(nameOrConnectionString: "DateExampleConnection")
        {

        }

        public static Week11Context Create()
        {
            return new Week11Context();
        }
    }
}
