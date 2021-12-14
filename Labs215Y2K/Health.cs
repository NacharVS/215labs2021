using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Health
    {
		public delegate void HealthValueChangedDelegate(); 

		private double _currentHealth;
		private double _maxHealth;
		private bool _isWeaken;

		public Health(int maxHealth)
		{
			_currentHealth = maxHealth;
			_maxHealth = maxHealth;
		}

		public double MaxHealth
		{
			get { return _maxHealth; }
			private set 
			{
				if (_isWeaken)
				{
					_maxHealth -= _maxHealth * 0.1;
				}
				else
				_maxHealth = value; 
			}
		}


		public double CurrentHealth
		{
			get { return _currentHealth; }
			set 
			{ 
				if(_currentHealth + value > MaxHealth)
				{
					_currentHealth = MaxHealth;
				}
				else
				_currentHealth = value; 
			}
		}

		public bool IsWeaken { get => _isWeaken; }

		public event HealthValueChangedDelegate HealthChangedEvent;
				
	}
}
