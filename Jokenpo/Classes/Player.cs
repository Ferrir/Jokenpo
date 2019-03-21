using JokenPO.Enums;
using System;

namespace JokenPO.Classes
{
	/// <summary>
	/// Classe model Player
	/// </summary>
	public sealed class Player
	{
		private String name;

		/// <summary>
		/// Get and Set Name
		/// </summary>
		public String Name {
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Class constructor
		/// </summary>
		/// <param name="name"></param>
		public Player(String name)
		{
			this.name = name;
		}

		/// <summary>
		/// Get and Set Game Otpion Player
		/// </summary>
		public GameOption GameOption { get; private set; }

		/// <summary>
		/// Set Game Option choice player
		/// </summary>
		/// <param name="gameOption"></param>
		public void Play(GameOption gameOption)
		{
			this.GameOption = gameOption;
		}
	}
}
