using System;
using System.ComponentModel;

namespace TmbAnalyst.Services.Utilities.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Returns the value of the enum's description decorator as a string.
    /// </summary>
    /// <param name="enumValue"></param>
    /// <returns></returns>
    public static string GetEnumDescription(this Enum enumValue)
    {
        var type = enumValue.GetType();
        var memberInfos = type.GetMember(enumValue.ToString());
        if (memberInfos.Length > 0)
        {
            var attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }
        }
        return null;
    }
}