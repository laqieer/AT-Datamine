// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAnchorMin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000508")]
  [AddComponentMenu("Tween/Tweeners/Tween Anchor Min")]
  [RequireComponent(typeof (RectTransform))]
  public class TweenAnchorMin : UITweener
  {
    [Token(Token = "0x4001AEE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector2 from;
    [Token(Token = "0x4001AEF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Vector2 to;
    [Token(Token = "0x4001AF0")]
    [FieldOffset(Offset = "0x78")]
    private RectTransform rectTransform;

    [Token(Token = "0x170003A7")]
    public Vector2 From
    {
      [Token(Token = "0x6001CFC"), Address(RVA = "0x29F7E6C", Offset = "0x29F7E6C", VA = "0x29F7E6C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001CFD"), Address(RVA = "0x29F7E74", Offset = "0x29F7E74", VA = "0x29F7E74")] set
      {
      }
    }

    [Token(Token = "0x170003A8")]
    public Vector2 To
    {
      [Token(Token = "0x6001CFE"), Address(RVA = "0x29F7E7C", Offset = "0x29F7E7C", VA = "0x29F7E7C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001CFF"), Address(RVA = "0x29F7E84", Offset = "0x29F7E84", VA = "0x29F7E84")] set
      {
      }
    }

    [Token(Token = "0x170003A9")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6001D00"), Address(RVA = "0x29F7E8C", Offset = "0x29F7E8C", VA = "0x29F7E8C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003AA")]
    public Vector2 Value
    {
      [Token(Token = "0x6001D01"), Address(RVA = "0x29F7F20", Offset = "0x29F7F20", VA = "0x29F7F20")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001D02"), Address(RVA = "0x29F7F3C", Offset = "0x29F7F3C", VA = "0x29F7F3C")] set
      {
      }
    }

    [Token(Token = "0x6001D03")]
    [Address(RVA = "0x29F7F70", Offset = "0x29F7F70", VA = "0x29F7F70", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D04")]
    [Address(RVA = "0x29F7F90", Offset = "0x29F7F90", VA = "0x29F7F90")]
    public TweenAnchorMin()
    {
    }
  }
}
