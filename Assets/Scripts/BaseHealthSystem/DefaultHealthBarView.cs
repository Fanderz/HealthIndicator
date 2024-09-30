using UnityEngine;
using UnityEngine.UI;

public class DefaultHealthBarView : BaseHealthBar
{
    [SerializeField] private Slider _slider;

    public override void ChangeHealthView(float value)
    {
        _slider.value = value / Health.MaxHealth;
    }
}
