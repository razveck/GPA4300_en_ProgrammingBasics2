using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {
	//1. interfaces cannot define things. They can only DECLARE.
	//2. interfaces cannot declare data
	//3. all members of an interface inherit its access modifier (interfaces/members cannot be private)
	interface IFlyer {
		void Fly();
	}
}
