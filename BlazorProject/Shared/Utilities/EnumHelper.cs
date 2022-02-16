using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorProject.Shared.Utilities
{
    public class EnumHelper
    {
        public static List<DropDownListItem> ConvertEnumToDropDownSource<T>(string initialText, string initialValue) where T : Enum
        {
            List<DropDownListItem> ret = new List<DropDownListItem>();

            var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();

            if(!string.IsNullOrEmpty(initialValue) || !string.IsNullOrEmpty(initialText))
            {
                DropDownListItem dropDownListItem = new DropDownListItem
                {
                    Text = initialText,
                    Value = initialValue
                };
                ret.Add(dropDownListItem);
            }

            for (int i = 0; i < Enum.GetNames(typeof(T)).Length; i++)
            {
                DropDownListItem dropDownListItem = new DropDownListItem
                {
                    Text = Enum.GetNames(typeof(T))[i],
                    Value = values[i].ToString()
                };
                ret.Add(dropDownListItem);
            }
            return ret;
        }
    }
}
