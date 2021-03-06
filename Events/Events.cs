﻿using System;

namespace Events {

	class Player{
		private float _health;

		//HealthBar healthBar;
		//DynamicDifficulty difficulty;

		public event Action<float> HealthChanged;

		public void DealDamage(float damage){
			_health -= damage;
			//healthBar.ChangeHealth(Health);
			//difficulty.ChangeDifficulty(Health);

			//raise the event
			//always null check
			if(HealthChanged != null)
				HealthChanged(_health);

			//the ?. operator is the same as doing if(HealthChanged != null)
			//Invoke is the same as raising the event directly
			HealthChanged?.Invoke(_health);


		}
	}

	class HealthBar{

		public Player Player;

		public HealthBar(Player player) {
			Player = player;
			Player.HealthChanged += ChangeHealth;
		}

		public void ChangeHealth(float health){
			//...
		}
	}

	class DynamicDifficulty{
		public Player Player;

		public DynamicDifficulty(Player player) {
			Player = player;
			Player.HealthChanged += ChangeDifficulty;
		}

		public void ChangeDifficulty(float health){
			//...
		}
	}

	class Events {
		static void Main(string[] args) {
			Player player = new Player();
			HealthBar healthbar = new HealthBar(player);
			DynamicDifficulty difficulty = new DynamicDifficulty(player);

			player.DealDamage(10);
		}
	}
}
