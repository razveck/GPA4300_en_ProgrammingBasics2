using System;

namespace ProgrammingBasics2 {
	class ReferenceType{
		public int count = 5;
	}

	struct  ValueType{

	}

	class StackAndHeap {
		static void Foo(){
			//1. variables and their values are stored on the stack

			//value of v = data of v
			//the new object on the stack. The value of v is THE OBJECT itself
			int a = 5;
			ValueType v = new ValueType();

			//2. reference types (classes) are ALWAYS stored on the heap

			//value of r != data of r
			//the new object is on the heap. It's location on the heap is stored inside r, on the stack
			ReferenceType r = new ReferenceType();

			//3. value types are stored wherever their enclosing scope is
			//the value type r.count is stored on the heap, because r is stored on the heap
			r.count = 10;
		}

		//since this is a member of a class, it goes on the heap, inside of a special location for static variables
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
			//the value of object1 (location in memory) is copied into object2. The heap is never changed in this process
			object2 = object1;

			Recurse(0);

		}

		static void Recurse(int count){
			count++;
			if(count < 10)
				Recurse(count);
		}

	}
}
