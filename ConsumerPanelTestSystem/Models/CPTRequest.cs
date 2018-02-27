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
    /// This class contains the information regarding a CPT request - who submitted it, the approvals regarding it as well as the final decision.
    /// </summary> 

    [Table("CPTRequest")]
    public partial class CPTRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPTRequest()
        {
            ExecutionLocations = new HashSet<ExecutionLocation>();
            ProgressReports = new HashSet<ProgressReport>();
            SelectQuestionnaires = new HashSet<SelectQuestionnaire>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestID { get; set; }

        [StringLength(100)]
        public string RequestTitle { get; set; }

        [Column(TypeName = "date")]
        public DateTime RequestDate { get; set; }

        public int RequestStatus { get; set; }

        public int ProductDivision { get; set; }

        [Required]
        [StringLength(200)]
        public string Justification { get; set; }

        public int MEmployeeID { get; set; }

        public int MReviewRequest { get; set; }

        public int BEmployeeID { get; set; }

        public int BReviewRequest { get; set; }

        public int BDecision { get; set; }

        public int REmployeeID { get; set; }

        [StringLength(100)]
        public string BDecisionMade { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BDecisionDate { get; set; }

        [StringLength(100)]
        public string BFeedback { get; set; }

        [StringLength(100)]
        public string MDecision { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MDecisionDate { get; set; }

        [StringLength(100)]
        public string MFeedback { get; set; }

        public virtual BrandManager BrandManagerDecision { get; set; }

        public virtual BrandManager BrandManagerSubmitRequest { get; set; }

        public virtual BrandManager BrandManagerReviewRequest { get; set; }

        public virtual MarketingDirector MarketingDirectorDecision { get; set; }

        public virtual MarketingDirector MarketingDirectorReviewRequest { get; set; }

        public virtual Requester Requester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExecutionLocation> ExecutionLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressReport> ProgressReports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectQuestionnaire> SelectQuestionnaires { get; set; }
    }
}
