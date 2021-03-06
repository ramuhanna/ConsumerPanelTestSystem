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
    /// This class describes any additional questions that may be added to a questionnaire by the CPT Coordinator during editing.
    /// </summary> 

    [Table("AdditionalQuestion")]
    public partial class AdditionalQuestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdditionalQuestionID { get; set; }

        public int QuestionnaireID { get; set; }

        [Column("AdditionalQuestion")]
        [StringLength(200)]
        public string AdditionalQuestion1 { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }
    }
}
