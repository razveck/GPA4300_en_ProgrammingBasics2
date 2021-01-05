using System;

namespace Properties {

	class Person {
		//backing field of the property
		private string _name;
		public string NameProperty
		{
			get
			{
				if(_name == null)
					_name = "Default";
				return _name;
			}
			set
			{
				_name = value;
				Console.WriteLine($"The new name is {_name}");
			}
		}

		public string GetName() {
			return _name;
		}

		public void SetName(string value) {
			_name = value;
		}

		//auto-property
		public string AutoProperty { get; set; }

		public string ReadOnlyProperty { get; private set; }

		public string WriteOnlyProperty { private get; set; }

		public string PropertyWithInitialValue { get; set; } = "BlaBla";


		private bool PropertyWithArrows {
			get => true;
			set => Console.WriteLine("Set the value");
		}

		private string description;
		public string Description { get => description; set => description = value; }

		public Person() {
			ReadOnlyProperty = "Readonly";
		}

	}
	
	class Properties {
		static void Main(string[] args) {
			Person person = new Person();
			Console.WriteLine(person.NameProperty);

			person.NameProperty = "Joao";

			Console.WriteLine(person.ReadOnlyProperty);

			person.Description = "This is a person";
			Console.WriteLine(person.Description);

		}
	}
}
