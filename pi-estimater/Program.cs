using System;

namespace piestimater {
	class MainClass {
		public static void Main(string[] args) {
			Random rng = new Random();

			int points= 100000000;
			int unit_circle = 0;

			for (int i = 0; i < points;) {
				double x = rng.NextDouble();
				double y = rng.NextDouble();

				if (x * x + y * y <= 1) {
					unit_circle++;
				}
				i++;
			}
			double pi = 4.0 * unit_circle / points;
			Console.WriteLine("PI er estimeret til: " + pi);
		}
	}
}