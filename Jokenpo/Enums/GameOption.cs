using System;
using System.ComponentModel;
using System.Reflection;

namespace JokenPO.Enums {
	/// <summary>
	/// Emun game options
	/// </summary>
	public enum GameOption {
		[DescriptionAttribute("Pedra")]
		Rock = 1,
		[DescriptionAttribute("Papel")]
		Paper = 2,
		[DescriptionAttribute("Tesoura")]
		Scissors = 3
	}//enum

	/// <summary>
	/// Extension Methods for enum
	/// </summary>
	public static class __ExtensionMethods {
		/// <summary>
		/// Get DescriptionAttribute item emnun 
		/// </summary>
		/// <param name="gameOption"></param>
		/// <returns></returns>
		public static String GetDescription(this GameOption gameOption) {
			Type type = gameOption.GetType();
			MemberInfo[] memberInfo = type.GetMember(gameOption.ToString());
			if (memberInfo != null && memberInfo.Length > 0) {
				object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
				if (attrs != null && attrs.Length > 0)
					return ((DescriptionAttribute)attrs[0]).Description;
			}//if
			return gameOption.ToString();
		}
	}
}
