//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalStockSystemTest.EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class StonkTable
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> stonkID { get; set; }
        public string type { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<double> tax { get; set; }
        public Nullable<double> fax { get; set; }
        public Nullable<System.DateTime> initDate { get; set; }
        public Nullable<int> total { get; set; }
    }
}
