using JokenPO.Classes;
using JokenPO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JokenPO {
	public class Program {
		private const Int32 CHOICE_MIN = 0;
		private const Int32 CHOICE_MAX = 3;

		private static List<GameOption> choices = Enum.GetValues(typeof(GameOption)).Cast<GameOption>().ToList();
		private static readonly Game game = new Game(new Player("Você"), new Player("CPU"));

		/// <summary>
		/// Start Player One
		/// </summary>
		/// <param name="player"></param>
		private static void PlayerGame(Player player) {
			Int32 choice;
			Console.WriteLine("Informe a sua opção:");

			while (!CheckOption(Console.ReadLine(), out choice)) {
				Console.WriteLine("Opção inválida! Vamos tentar outra vez.");
				Console.WriteLine("Informe a sua opção:");
			}//while

			if (choice == 0) Environment.Exit(1);

			player.Play((GameOption)choice);
		}

		/// <summary>
		/// Start CPU Player
		/// </summary>
		/// <param name="player"></param>
		private static void CPUGame(Player player) {
			Random randon = new Random();

			Int32 choice = randon.Next(1, choices.Count + 1);

			player.Play((GameOption)choice);
		}

		/// <summary>
		/// Validation of the selected option
		/// </summary>
		/// <param name="option"></param>
		/// <param name="choice"></param>
		/// <returns></returns>
		private static Boolean CheckOption(String option, out Int32 choice) {
			choice = Int32.MinValue;
			if (option.Equals(String.Empty)) return false;

			if (!Int32.TryParse(option, out choice)) return false;

			if (choice < CHOICE_MIN || choice > CHOICE_MAX) return false;

			return true;
		}

		/// <summary>
		/// Main
		/// </summary>
		/// <param name="args"></param>
		private static void Main(string[] args) {
			while (true) {
				Console.WriteLine("Bem-vindo ao Jokenpo");
				Console.Write("Opções: ");

				foreach (GameOption choice in choices)
					Console.Write(string.Format("{0} - {1} | ", (Int32)choice, choice.GetDescription()));

				Console.WriteLine("0 - Sair\n");

				PlayerGame(game.Player);
				CPUGame(game.Cpu);

				Console.WriteLine(game.ReturnWinner());

				Console.ReadKey();
				Console.Clear();

			}//while
		}
	}
}
