// Decompiled with JetBrains decompiler
// Type: LoginBonus.TweenAnimationStateHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AEE")]
  internal class TweenAnimationStateHandle : IAnimationStateHandle
  {
    [Token(Token = "0x4003217")]
    [FieldOffset(Offset = "0x10")]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003218")]
    [FieldOffset(Offset = "0x18")]
    private Action finishedCallback;
    [Token(Token = "0x4003219")]
    [FieldOffset(Offset = "0x20")]
    private bool isSkipped;
    [Token(Token = "0x400321A")]
    [FieldOffset(Offset = "0x21")]
    private bool isNotifyFinished;

    [Token(Token = "0x6003E4C")]
    [Address(RVA = "0x2C149EC", Offset = "0x2C149EC", VA = "0x2C149EC")]
    public TweenAnimationStateHandle(UITweenGroup tweenGroup, Action finishedCallback)
    {
    }

    [Token(Token = "0x6003E4D")]
    [Address(RVA = "0x2C14A98", Offset = "0x2C14A98", VA = "0x2C14A98", Slot = "6")]
    public bool IsFinished() => new bool();

    [Token(Token = "0x6003E4E")]
    [Address(RVA = "0x2C14AC0", Offset = "0x2C14AC0", VA = "0x2C14AC0", Slot = "5")]
    public bool IsSkipped() => new bool();

    [Token(Token = "0x6003E4F")]
    [Address(RVA = "0x2C14AC8", Offset = "0x2C14AC8", VA = "0x2C14AC8", Slot = "4")]
    public void Skip()
    {
    }

    [Token(Token = "0x6003E50")]
    [Address(RVA = "0x2C14BBC", Offset = "0x2C14BBC", VA = "0x2C14BBC", Slot = "7")]
    public IEnumerator WaitForFinished(Action onUpdate) => (IEnumerator) null;

    [Token(Token = "0x6003E51")]
    [Address(RVA = "0x2C14B08", Offset = "0x2C14B08", VA = "0x2C14B08")]
    private void OnFinished()
    {
    }
  }
}
