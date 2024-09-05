// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.ForceSliderToPowerOf2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene
{
  [Token(Token = "0x20003A8")]
  public class ForceSliderToPowerOf2 : MonoBehaviour
  {
    [Token(Token = "0x40015D9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider m_slider;
    [Token(Token = "0x40015DA")]
    [FieldOffset(Offset = "0x20")]
    private int[] m_powerOf2Values;
    [Token(Token = "0x40015DB")]
    [FieldOffset(Offset = "0x28")]
    private Text m_text;

    [Token(Token = "0x6001541")]
    [Address(RVA = "0x247E810", Offset = "0x247E810", VA = "0x247E810")]
    private void Start()
    {
    }

    [Token(Token = "0x6001542")]
    [Address(RVA = "0x247E8B8", Offset = "0x247E8B8", VA = "0x247E8B8")]
    private void UpdateValue(float value)
    {
    }

    [Token(Token = "0x6001543")]
    [Address(RVA = "0x247E9BC", Offset = "0x247E9BC", VA = "0x247E9BC")]
    public ForceSliderToPowerOf2()
    {
    }
  }
}
