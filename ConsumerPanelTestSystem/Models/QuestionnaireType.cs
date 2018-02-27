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
    /// This class pertains to the selection of the questionnaire types to which a single question belongs.
    /// </summary> 

    [Table("QuestionnaireType")]
    public partial class QuestionnaireType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionnaireTypeID { get; set; }

        public int QuestionID { get; set; }

        [Column("QuestionnaireType")]
        public int QuestionnaireType1 { get; set; }

        public virtual Question Question { get; set; }
    }
}
