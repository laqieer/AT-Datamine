// Decompiled with JetBrains decompiler
// Type: LoginBonus.TimlineStateHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine.Playables;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AF1")]
  internal class TimlineStateHandle : IAnimationStateHandle
  {
    [Token(Token = "0x4003221")]
    [FieldOffset(Offset = "0x10")]
    private PlayableDirector playableDirector;
    [Token(Token = "0x4003222")]
    [FieldOffset(Offset = "0x18")]
    private Action finishedCallback;
    [Token(Token = "0x4003223")]
    [FieldOffset(Offset = "0x20")]
    private bool isSkipped;
    [Token(Token = "0x4003224")]
    [FieldOffset(Offset = "0x21")]
    private bool isNotifyFinished;

    [Token(Token = "0x6003E5A")]
    [Address(RVA = "0x2C14E0C", Offset = "0x2C14E0C", VA = "0x2C14E0C")]
    public TimlineStateHandle(PlayableDirector playableDirector, Action finishedCallback)
    {
    }

    [Token(Token = "0x6003E5B")]
    [Address(RVA = "0x2C14EBC", Offset = "0x2C14EBC", VA = "0x2C14EBC", Slot = "6")]
    public bool IsFinished() => new bool();

    [Token(Token = "0x6003E5C")]
    [Address(RVA = "0x2C14EE4", Offset = "0x2C14EE4", VA = "0x2C14EE4", Slot = "5")]
    public bool IsSkipped() => new bool();

    [Token(Token = "0x6003E5D")]
    [Address(RVA = "0x2C14EEC", Offset = "0x2C14EEC", VA = "0x2C14EEC", Slot = "4")]
    public void Skip()
    {
    }

    [Token(Token = "0x6003E5E")]
    [Address(RVA = "0x2C15038", Offset = "0x2C15038", VA = "0x2C15038", Slot = "7")]
    public IEnumerator WaitForFinished(Action onUpdate) => (IEnumerator) null;

    [Token(Token = "0x6003E5F")]
    [Address(RVA = "0x2C14F84", Offset = "0x2C14F84", VA = "0x2C14F84")]
    private void OnFinished(PlayableDirector playableDirector)
    {
    }
  }
}
