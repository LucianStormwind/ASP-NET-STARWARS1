﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLength = 100)
        {
            if (text.Length == null || text.Length <= maxLength)
                return text;
            var shortText = text.Substring(0, maxLength) + "...";
            return shortText;

        }
    }
}