using System;
using System.Collections.Generic;

namespace Interfaces {
	class Interfaces {

		static IFlyer flyer;

		static void Main(string[] args) {
			List<Animal> animals = new List<Animal>();
			Dog d = new Dog();
			animals.Add(d);
			Bird b = new Bird();
			animals.Add(b);
			
			foreach(Animal animal in animals) {
				animal.Foo();
				//Bird bird = animal as Bird;
				//if(bird != null) {
				//	Console.WriteLine("The animal can fly");
				//	MakeFly(bird);
				//	continue;
				//}

				//Bat bat = animal as Bat;
				//if(bat != null) {
				//	Console.WriteLine("The animal can fly");
				//	MakeFly(bat);
				//	continue;
				//}

				IFlyer flyer = animal as IFlyer;
				if(flyer != null){
					Console.WriteLine("The animal can fly");
					MakeFly(flyer);
					continue;
				}
			}
		}

		static void MakeFly(IFlyer flyer){
			flyer.Fly();
		}
	}
}
