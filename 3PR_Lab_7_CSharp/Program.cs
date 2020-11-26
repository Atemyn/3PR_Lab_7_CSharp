﻿using System;
using System.Collections.Generic;

namespace _3PR_Lab_7_СSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Работа с экземплярами класса. */
			Building firstBuilding = new Building();
			Building secondBuilding = new Building();

			Console.WriteLine("Программа по созданию зданий.\nВсе размерные данные вводятся в метрах.\n");
			Console.WriteLine("Работа с экземплярами класса: ");

			firstBuilding.inputBuilding();
			secondBuilding.initBuilding();

			firstBuilding.addToBuilding(secondBuilding);

			firstBuilding.addFloors();
			firstBuilding.removeFloors();
			/*............................................*/

			/* Список объектов. */
			List<Building> firstDynamicArray = new List<Building>();
			Building helpBuilding = new Building();

			Console.WriteLine("\nСписок объектов: ");

			firstDynamicArray.Add(new Building());
			firstDynamicArray[0].inputBuilding();
			firstDynamicArray.Add(new Building());
			firstDynamicArray[1].initBuilding();
			firstDynamicArray[0].addToBuilding(firstDynamicArray[1]);
			/*...............................*/

			const int amount = 2;
			/* Массив экземпляров. */
			Building[] firstArrayOfDyn = new Building[amount];
			Building[] secondArrayOfDyn = new Building[amount];
			for (int i = 0; i < amount; i++)
			{
				firstArrayOfDyn[i] = new Building();
				secondArrayOfDyn[i] = new Building();
			}

			Console.WriteLine("\nМассив объектов: ");

			firstArrayOfDyn[0].inputBuilding();
			secondArrayOfDyn[1].initBuilding();

			firstArrayOfDyn[0].addToBuilding(secondArrayOfDyn[1]);
			/*..............................*/

			/* Новые функции Ассоциации. */
			Building building = new Building();
			Console.WriteLine("\nНовые функции Ассоциации: ");

			building.inputBuilding();

			building.openWindowsOnFacade();
			building.closeWindowsOnFacade();
			/*..........................*/

			/* Использование ref и out.*/
			building = new Building();
			double numRef, numOut;

			Console.WriteLine("\nИспользование ref и out: ");
			building.inputBuilding();
			// Использование out: инициализация не нужна.
			building.returnStabilityFactor(out numOut);
			Console.WriteLine("\nКоэффициент устойчивости через out: " + numOut);
			// Использование ref: инициализация необходима для отсутствия ошибки.
			numRef = 0;
			building.returnSideLength(ref numRef);
			Console.WriteLine("\nДлина стороны через ref: " + numRef);
			/*........................*/
		}
	}
}
