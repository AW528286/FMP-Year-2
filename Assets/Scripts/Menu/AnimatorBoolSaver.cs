using System.Collections.Generic;
using UnityEngine;

public class AnimatorBoolSaver : MonoBehaviour
{
    private Animator _animator = null;
    private Dictionary<string, bool> _boolValues = new Dictionary<string, bool>();

    public void SetBool(string boolName, bool value)
    {
        _boolValues[boolName] = value;
        if (_animator != null)
        {
            _animator.SetBool(boolName, value);
        }
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        if (_animator != null)
        {
            foreach (var keyValue in _boolValues)
            {
                _animator.SetBool(keyValue.Key, keyValue.Value);
            }
        }
    }
}