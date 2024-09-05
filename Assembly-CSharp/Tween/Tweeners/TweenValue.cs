// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200051E")]
  [AddComponentMenu("Tween/Tweeners/Tween Value")]
  public class TweenValue : UITweener
  {
    [Token(Token = "0x4001B3F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private int from;
    [Token(Token = "0x4001B40")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private int to;
    [Token(Token = "0x4001B41")]
    [FieldOffset(Offset = "0x70")]
    private int count;

    [Token(Token = "0x170003E9")]
    public int From
    {
      [Token(Token = "0x6001DAF"), Address(RVA = "0x29FAFC8", Offset = "0x29FAFC8", VA = "0x29FAFC8")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DB0"), Address(RVA = "0x29FAFD0", Offset = "0x29FAFD0", VA = "0x29FAFD0")] set
      {
      }
    }

    [Token(Token = "0x170003EA")]
    public int To
    {
      [Token(Token = "0x6001DB1"), Address(RVA = "0x29FAFD8", Offset = "0x29FAFD8", VA = "0x29FAFD8")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DB2"), Address(RVA = "0x29FAFE0", Offset = "0x29FAFE0", VA = "0x29FAFE0")] set
      {
      }
    }

    [Token(Token = "0x170003EB")]
    public int Value
    {
      [Token(Token = "0x6001DB3"), Address(RVA = "0x29FAFE8", Offset = "0x29FAFE8", VA = "0x29FAFE8")] get
      {
        return new int();
      }
      [Token(Token = "0x6001DB4"), Address(RVA = "0x29FAFF0", Offset = "0x29FAFF0", VA = "0x29FAFF0")] set
      {
      }
    }

    [Token(Token = "0x6001DB5")]
    [Address(RVA = "0x29FAFF8", Offset = "0x29FAFF8", VA = "0x29FAFF8", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001DB6")]
    [Address(RVA = "0x29FB0F8", Offset = "0x29FB0F8", VA = "0x29FB0F8")]
    public TweenValue()
    {
    }
  }
}
