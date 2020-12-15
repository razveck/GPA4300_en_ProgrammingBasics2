using System;

namespace ProgrammingBasics2 {
	class ReferenceType
    {
		public int count = 5;
    }
	struct ValueType
    {

    }
	class StackAndHeap {

		//since this is a member of a class, it goes on the heap, insde of a special location for static variables
		static int age = 29;

		//since this is a member of a class, it goes on the heap, inside of a its enclosing object
		float height = 1.8f;
		static void Main(string[] args) {
			Foo();

			//valueTypeArray is on the stack
			//its value is a reference (location in memory) to the data
			//the data (the individual ValueType objects) are stored on the heap
			ValueType[] valueTypeArray = new ValueType[10];

			ReferenceType object1 = new ReferenceType();
			ReferenceType object2 = new ReferenceType();
			//the value of object1 (location in memory) is copied into object 2. The heap is never changed in this process
			object1 = object2;

			Recurse(0);
		}
		static void Recurse(int count)
        {
			count++;
			if (count < 10)
				Recurse(count);
        }

		static void Foo()
        {
			//1.variables and their values are stored on the stack
				//1.1 structs (Value Types) declared inside of a function are stored on the stack
			int a = 5;
			
			//value of v = data of v
			//the new object on the stack. The value of V is the OBJECT itself
			ValueType v = new ValueType();

			//2. reference types (classes) are ALWAYS stored on the heap
			
			//value of r != data of r
			//the new object is on the heap. It's location on the heap is stored inside r, on the stack
			ReferenceType r = new ReferenceType();

			//3. value typed are stored wherever their enclosing scope is
			//the value type r.count is stoed on the heap, because r is stored on the heap
			r.count = 10;
        }
	}
}
