// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAlpha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Tween.Tweeners.TweenAlphaInternal;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000505")]
  [AddComponentMenu("Tween/Tweeners/Tween Alpha")]
  public class TweenAlpha : UITweener
  {
    [Token(Token = "0x4001AE5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float from;
    [Token(Token = "0x4001AE6")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float to;
    [Token(Token = "0x4001AE7")]
    [FieldOffset(Offset = "0x70")]
    private bool cached;
    [Token(Token = "0x4001AE8")]
    [FieldOffset(Offset = "0x78")]
    private IAlphaHandler alphaHandler;

    [Token(Token = "0x170003A0")]
    public float From
    {
      [Token(Token = "0x6001CE7"), Address(RVA = "0x29F77B4", Offset = "0x29F77B4", VA = "0x29F77B4")] get
      {
        return new float();
      }
      [Token(Token = "0x6001CE8"), Address(RVA = "0x29F77BC", Offset = "0x29F77BC", VA = "0x29F77BC")] set
      {
      }
    }

    [Token(Token = "0x170003A1")]
    public float To
    {
      [Token(Token = "0x6001CE9"), Address(RVA = "0x29F77C4", Offset = "0x29F77C4", VA = "0x29F77C4")] get
      {
        return new float();
      }
      [Token(Token = "0x6001CEA"), Address(RVA = "0x29F77CC", Offset = "0x29F77CC", VA = "0x29F77CC")] set
      {
      }
    }

    [Token(Token = "0x6001CEB")]
    [Address(RVA = "0x29F77D4", Offset = "0x29F77D4", VA = "0x29F77D4")]
    private void Cache()
    {
    }

    [Token(Token = "0x170003A2")]
    public float Value
    {
      [Token(Token = "0x6001CEC"), Address(RVA = "0x29F7A88", Offset = "0x29F7A88", VA = "0x29F7A88")] get
      {
        return new float();
      }
      [Token(Token = "0x6001CED"), Address(RVA = "0x29F7B58", Offset = "0x29F7B58", VA = "0x29F7B58")] set
      {
      }
    }

    [Token(Token = "0x6001CEE")]
    [Address(RVA = "0x29F7C3C", Offset = "0x29F7C3C", VA = "0x29F7C3C", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001CEF")]
    [Address(RVA = "0x29F77F4", Offset = "0x29F77F4", VA = "0x29F77F4")]
    private IAlphaHandler TryGetAlphaHandler() => (IAlphaHandler) null;

    [Token(Token = "0x6001CF0")]
    [Address(RVA = "0x29F7D0C", Offset = "0x29F7D0C", VA = "0x29F7D0C")]
    public TweenAlpha()
    {
    }
  }
}
