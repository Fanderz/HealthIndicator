using System;
using TMPro;
using UnityEngine;

public class TextHealthBarView : BaseHealthBar
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        ChangeHealthView(Health.Value);
    }

    public override void ChangeHealthView(float value)
    {
        _text.text = $"{(int)Math.Ceiling(value)}/{Health.MaxHealth}";
    }
}
