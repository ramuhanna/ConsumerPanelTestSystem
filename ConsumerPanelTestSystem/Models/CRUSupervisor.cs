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
    /// This class describes the CRU Supervisor user who assigns work to CRU Members and verifies results. 
    /// </summary>

    [Table("CRUSupervisor")]
    public partial class CRUSupervisor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRUSupervisor()
        {
            Answers = new HashSet<Answer>();
            AssignWorks = new HashSet<AssignWork>();
            CRUMembers = new HashSet<CRUMember>();
            ProgressReports = new HashSet<ProgressReport>();
            ResponsibleFors = new HashSet<ResponsibleFor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignWork> AssignWorks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRUMember> CRUMembers { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressReport> ProgressReports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResponsibleFor> ResponsibleFors { get; set; }
    }
}
