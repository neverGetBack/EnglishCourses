//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishCourse_Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lesson
    {
        public int id_Lesson { get; set; }
        public Nullable<int> Number { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public Nullable<int> id_Theme { get; set; }
        public string Lesson_link { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> id_Course { get; set; }
        public Nullable<bool> isDelete { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Theme Theme { get; set; }
    }
}