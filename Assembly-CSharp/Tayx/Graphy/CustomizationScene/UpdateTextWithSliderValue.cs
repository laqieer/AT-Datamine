// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.UpdateTextWithSliderValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene
{
  [Token(Token = "0x20003A9")]
  [RequireComponent(typeof (Text))]
  public class UpdateTextWithSliderValue : MonoBehaviour
  {
    [Token(Token = "0x40015DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider m_slider;
    [Token(Token = "0x40015DD")]
    [FieldOffset(Offset = "0x20")]
    private Text m_text;

    [Token(Token = "0x6001544")]
    [Address(RVA = "0x247EA40", Offset = "0x247EA40", VA = "0x247EA40")]
    private void Start()
    {
    }

    [Token(Token = "0x6001545")]
    [Address(RVA = "0x247EB0C", Offset = "0x247EB0C", VA = "0x247EB0C")]
    private void UpdateText(float value)
    {
    }

    [Token(Token = "0x6001546")]
    [Address(RVA = "0x247EB54", Offset = "0x247EB54", VA = "0x247EB54")]
    public UpdateTextWithSliderValue()
    {
    }
  }
}
