// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenHeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000510")]
  [AddComponentMenu("Tween/Tweeners/Tween Height")]
  [RequireComponent(typeof (RectTransform))]
  public class TweenHeight : UITweener
  {
    [Token(Token = "0x4001B0A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private int from;
    [Token(Token = "0x4001B0B")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private int to;
    [Token(Token = "0x4001B0C")]
    [FieldOffset(Offset = "0x70")]
    private RectTransform widget;

    [Token(Token = "0x170003BA")]
    public int From
    {
      [Token(Token = "0x6001D37"), Address(RVA = "0x29F8F60", Offset = "0x29F8F60", VA = "0x29F8F60")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D38"), Address(RVA = "0x29F8F68", Offset = "0x29F8F68", VA = "0x29F8F68")] set
      {
      }
    }

    [Token(Token = "0x170003BB")]
    public int To
    {
      [Token(Token = "0x6001D39"), Address(RVA = "0x29F8F70", Offset = "0x29F8F70", VA = "0x29F8F70")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D3A"), Address(RVA = "0x29F8F78", Offset = "0x29F8F78", VA = "0x29F8F78")] set
      {
      }
    }

    [Token(Token = "0x170003BC")]
    public RectTransform CachedWidget
    {
      [Token(Token = "0x6001D3B"), Address(RVA = "0x29F8F80", Offset = "0x29F8F80", VA = "0x29F8F80")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003BD")]
    public int Value
    {
      [Token(Token = "0x6001D3C"), Address(RVA = "0x29F9014", Offset = "0x29F9014", VA = "0x29F9014")] get
      {
        return new int();
      }
      [Token(Token = "0x6001D3D"), Address(RVA = "0x29F904C", Offset = "0x29F904C", VA = "0x29F904C")] set
      {
      }
    }

    [Token(Token = "0x6001D3E")]
    [Address(RVA = "0x29F90A0", Offset = "0x29F90A0", VA = "0x29F90A0", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D3F")]
    [Address(RVA = "0x29F91A0", Offset = "0x29F91A0", VA = "0x29F91A0")]
    public TweenHeight()
    {
    }
  }
}
