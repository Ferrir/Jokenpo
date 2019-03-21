using JokenPO.Enums;
using System;

namespace JokenPO.Classes {
	public sealed class Game {
		private const String PLAYER_WIN = "Ganhou";
		private const String PLAYER_LOSE = "Perdeu";
		private const String PLAYER_DRAW = "Empatou";
		private const String MESSAGE = "{0} escolheu {1}, {2} escolheu {3} => {4} {5}";

		/// <summary>
		/// Class constructor
		/// </summary>
		/// <param name="player"></param>
		/// <param name="cpu"></param>
		public Game(Player player, Player cpu) {
			this.Player = player;
			this.Cpu = cpu;
		}

		/// <summary>
		/// Get and Set player one
		/// </summary>
		public Player Player { get; private set; }

		/// <summary>
		/// Get and Set player cpu
		/// </summary>
		public Player Cpu { get; private set; }

		/// <summary>
		/// Return Player Winner
		/// </summary>
		/// <returns></returns>
		public String ReturnWinner() {
			String message = PLAYER_DRAW;

			if (Player.GameOption == GameOption.Paper && Cpu.GameOption == GameOption.Rock)
				message = PLAYER_WIN;
			else if (Player.GameOption == GameOption.Paper && Cpu.GameOption == GameOption.Scissors)
				message = PLAYER_LOSE;
			else if (Player.GameOption == GameOption.Rock && Cpu.GameOption == GameOption.Paper)
				message = PLAYER_LOSE;
			else if (Player.GameOption == GameOption.Rock && Cpu.GameOption == GameOption.Scissors)
				message = PLAYER_WIN;
			else if (Player.GameOption == GameOption.Scissors && Cpu.GameOption == GameOption.Paper)
				message = PLAYER_WIN;
			else if (Player.GameOption == GameOption.Scissors && Cpu.GameOption == GameOption.Rock)
				message = PLAYER_LOSE;

			return String.Format(MESSAGE, Player.Name, Player.GameOption.GetDescription(), Cpu.Name, Cpu.GameOption.GetDescription(), Player.Name, message);
		}
	}
}
