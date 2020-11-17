using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Globalization;

public class BarraVida : MonoBehaviour
{
	public Scrollbar HealthBar;
	public Text HealthNumber;
	public float Health = 100;

	void Start()
    {
		HealthNumber.text = Health.ToString();
	}

	public void Damage(float value)
	{
		Health -= value;
		HealthBar.size = Health / 100f;
		HealthNumber.text = Health.ToString();
	}
}
