//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceWebAPI.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperationHistory
    {
        public int ID { get; set; }
        public int OperationTypeID { get; set; }
        public int OperationCategoryID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int UserID { get; set; }
    
        public virtual OperationCategory OperationCategory { get; set; }
        public virtual OperationType OperationType { get; set; }
        public virtual Users Users { get; set; }
    }
}