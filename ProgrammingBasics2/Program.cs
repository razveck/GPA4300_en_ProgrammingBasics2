using System;

namespace ProgrammingBasics2 {
	class ReferenceType
    {
		public int count = 5;
    }

	class ValueType
    {

    }

	class StackAndHeap {

		static void Foo()
		{
			// variables and their values are stored on the stack
			// structs (value types) declared inside of a function are stored on the stack
			int a = 5;

			ValueType v = new ValueType(); // value of V = data of V
										   // the new object is on the stack. The value of v is THE OBJECT itself

			ReferenceType r = new ReferenceType(); // value of r != data of r
												   // the new object is on the heap. Its location on the heap is stored inside
												   // r on the stack

			// 2. reference types are ALWAYS stored on the heap (also classes)
			// 3. value types are stored wherever their enclosing scope is
			// (value types go wherever you declare them)

			r.count = 10;
			// value type r.count is stored on the heap, because r is stored on the heap
		}

		// since this is a member of the class - it goes on the heap inside of a special location
		// for static variables
		static int age = 29;

		// since this is a member of the class - it goes on the heap inside of its enclosing object
		float height = 1.8f;

		static void Main(string[] args) {

			Foo();


			// its value is a reference (location in memory) to the data
			// the data (the individual value type objects) is stored on the heap
			ValueType[] valueTypeArray = new ValueType[10];

			ReferenceType object1 = new ReferenceType();
			ReferenceType object2 = new ReferenceType();
			// the value of object1 (location in memory) is copied into object2. The heap is never changed
			// in this process
			object2 = object1;

			Recurse(0);
		
			static void Recurse(int count)
            {
				count++;
                if (count < 10)
                {
					Recurse(10);
                }
            }


        }
	}
}
