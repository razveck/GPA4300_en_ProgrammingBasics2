using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine {
	[Serializable]
	class GameObject : Object {
		public List<Component> _components = new List<Component>();

		public Transform transform;
		public Scene scene;

		public GameObject() {
			transform = new Transform();
		}

		public void AddComponent(Component component){
			_components.Add(component);
		}
	}
}