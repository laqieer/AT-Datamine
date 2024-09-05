// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleConfigItemSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031CA")]
  public class BattleConfigItemSlider : MonoBehaviour
  {
    [Token(Token = "0x400D420")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider slider;
    [Token(Token = "0x400D421")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SliderHelper sliderHelper;
    [Token(Token = "0x400D422")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text valueText;
    [Token(Token = "0x400D424")]
    [FieldOffset(Offset = "0x38")]
    private float value;

    [Token(Token = "0x170040E4")]
    private Action<float> OnValueChangedAction
    {
      [Token(Token = "0x60136E2"), Address(RVA = "0x4E09EC4", Offset = "0x4E09EC4", VA = "0x4E09EC4")] get
      {
        return (Action<float>) null;
      }
      [Token(Token = "0x60136E3"), Address(RVA = "0x4E09ECC", Offset = "0x4E09ECC", VA = "0x4E09ECC")] set
      {
      }
    }

    [Token(Token = "0x60136E4")]
    [Address(RVA = "0x4E09ED4", Offset = "0x4E09ED4", VA = "0x4E09ED4")]
    public void Initialize(float value, Action<float> action)
    {
    }

    [Token(Token = "0x60136E5")]
    [Address(RVA = "0x4E0A070", Offset = "0x4E0A070", VA = "0x4E0A070")]
    public void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x60136E6")]
    [Address(RVA = "0x4E0A0F0", Offset = "0x4E0A0F0", VA = "0x4E0A0F0")]
    public void OnPointerUp(float value)
    {
    }

    [Token(Token = "0x60136E7")]
    [Address(RVA = "0x4E0A10C", Offset = "0x4E0A10C", VA = "0x4E0A10C")]
    public BattleConfigItemSlider()
    {
    }
  }
}
