using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KendoUIMvcApplication1.Models
{
    public class TestData
    {
        [UIHint("TextEditorTemplate")]
        public string TextOne { get; set; }
        public string TextTwo { get; set; }
        public string DropOne { get; set; }
        public int IntOne { get; set; }
    }
}