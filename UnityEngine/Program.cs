using System;
using System.IO;
using Newtonsoft.Json;

namespace UnityEngine {
	class Program {

		const string _path = "Scene.unity";
		private static JsonSerializerSettings _settings = new JsonSerializerSettings {
			ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
			PreserveReferencesHandling = PreserveReferencesHandling.Objects
		};

		static void Main(string[] args) {
			if(File.Exists(_path)) {
				string file = File.ReadAllText(_path);
				Scene scene = JsonConvert.DeserializeObject<Scene>(file, _settings);
			} else {


				//scene that is serialized
				Scene scene = new Scene();
				GameObject player = new GameObject();
				player.scene = scene;

				scene.GameObjects.Add(player);

				player.AddComponent(new MonoBehaviour());

				GameObject enemy = new GameObject();
				player.scene = scene;
				scene.GameObjects.Add(enemy);

				string json = JsonConvert.SerializeObject(scene, Formatting.Indented, _settings);
				File.WriteAllText(_path, json);
			}
		}
	}
}
