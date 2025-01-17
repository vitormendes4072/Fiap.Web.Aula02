﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Exemplo01.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";
                output.Content.SetContent(Texto);
                output.Attributes.SetAttribute("class", string.IsNullOrEmpty(Class) ? "alert alert-success" : Class);
            }
        }
    }
}
