using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine {
	[Serializable]
	class Transform : Component {
		private List<Transform> _children;

		public Vector3 position;
	}
}
