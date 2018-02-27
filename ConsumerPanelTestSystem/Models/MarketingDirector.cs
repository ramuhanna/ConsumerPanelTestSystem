/*
* Description: This class is part of the Consumer Panel Test System, a Web-Based application utilized for organized and systemized market research process.
* Author: R.M.
* Due date: 27/02/2018
*/

namespace ConsumerPanelTestSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>  
    /// This class describes the Marketing Director user responsible for reviewing all requests and final decision making. 
    /// </summary>

    [Table("MarketingDirector")]
    public partial class MarketingDirector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketingDirector()
        {
            MFinalizedRequests = new HashSet<CPTRequest>();
            MReveiewedRequests = new HashSet<CPTRequest>();
            Questionnaires = new HashSet<Questionnaire>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPTRequest> MFinalizedRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPTRequest> MReveiewedRequests { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}
