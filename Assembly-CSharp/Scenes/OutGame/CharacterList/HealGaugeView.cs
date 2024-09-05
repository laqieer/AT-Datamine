// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.HealGaugeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200372A")]
  public class HealGaugeView : MonoBehaviour
  {
    [Token(Token = "0x400F0ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectMask2D _rectMask2d;
    [Token(Token = "0x400F0EE")]
    [FieldOffset(Offset = "0x20")]
    private float _defaultMaskTopPosition;

    [Token(Token = "0x6015BC2")]
    [Address(RVA = "0x1B226D0", Offset = "0x1B226D0", VA = "0x1B226D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x170047E3")]
    public float value
    {
      [Token(Token = "0x6015BC3"), Address(RVA = "0x1B225A8", Offset = "0x1B225A8", VA = "0x1B225A8")] set
      {
      }
    }

    [Token(Token = "0x6015BC4")]
    [Address(RVA = "0x1B2274C", Offset = "0x1B2274C", VA = "0x1B2274C")]
    public void SetValue(float value)
    {
    }

    [Token(Token = "0x6015BC5")]
    [Address(RVA = "0x1B225C8", Offset = "0x1B225C8", VA = "0x1B225C8")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6015BC6")]
    [Address(RVA = "0x1B227F8", Offset = "0x1B227F8", VA = "0x1B227F8")]
    public HealGaugeView()
    {
    }
  }
}
