//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LBA
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Operation
    {
        public int operationId { get; set; }
        public int personFk { get; set; }
        public int operationTypeFk { get; set; }
        public string @operator { get; set; }
        public string cashdesk { get; set; }
        public Nullable<bool> cession { get; set; }
        public Nullable<bool> retrocession { get; set; }
        public System.DateTime operationDate { get; set; }
        public decimal operationAmount { get; set; }
        public string operationComment { get; set; }
    
        public virtual T_OperationType T_OperationType { get; set; }
        public virtual T_Person T_Person { get; set; }
    }
}