using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {

	abstract class Animal {
		public string Name;

		public abstract void Eat();

		public virtual void Foo(){
			Console.WriteLine("Base class foo");
		}
	}

	class Mammal : Animal{
		public override void Eat() {

		}
	}

	//Bird inherits from Animal and implements the IFlyer interface
	class Bird : Animal, IFlyer{
		public override void Eat() {
			throw new NotImplementedException();
		}

		public void Fly(){

		}

		public override void Foo() {
			Console.WriteLine("Bird foo");
		}
	}

	class Insect : Animal, IFlyer{
		public override void Eat() {
			throw new NotImplementedException();
		}

		public void Fly() {
			
		}
	}

	class Dog : Mammal{
		public void Bark(){

		}
	}

	class Cat : Mammal{

	}

	class Bat : Mammal, IFlyer{
		public void Fly(){

		}
	}
}
