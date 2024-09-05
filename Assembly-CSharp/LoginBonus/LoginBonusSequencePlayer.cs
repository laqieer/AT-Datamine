// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusSequencePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AEA")]
  internal class LoginBonusSequencePlayer
  {
    [Token(Token = "0x4003212")]
    [FieldOffset(Offset = "0x10")]
    private ILoginBonusSequence currentSequence;
    [Token(Token = "0x4003213")]
    [FieldOffset(Offset = "0x18")]
    private Queue<ILoginBonusSequence> waitingSequences;
    [Token(Token = "0x4003214")]
    [FieldOffset(Offset = "0x20")]
    private Action onCompleteAllSequences;

    [Token(Token = "0x17000909")]
    public bool IsPlaying
    {
      [Token(Token = "0x6003E38"), Address(RVA = "0x2C14140", Offset = "0x2C14140", VA = "0x2C14140")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003E39")]
    [Address(RVA = "0x2C14150", Offset = "0x2C14150", VA = "0x2C14150")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x6003E3A")]
    [Address(RVA = "0x2C14274", Offset = "0x2C14274", VA = "0x2C14274")]
    public void Play(Action onCompleteAllSequences)
    {
    }

    [Token(Token = "0x6003E3B")]
    [Address(RVA = "0x2C14538", Offset = "0x2C14538", VA = "0x2C14538")]
    public void Update()
    {
    }

    [Token(Token = "0x6003E3C")]
    [Address(RVA = "0x2C14390", Offset = "0x2C14390", VA = "0x2C14390")]
    private void StartNextSequence(Action onCompleteAllSequences)
    {
    }

    [Token(Token = "0x6003E3D")]
    [Address(RVA = "0x2C146B4", Offset = "0x2C146B4", VA = "0x2C146B4")]
    public void AddSequence(ILoginBonusSequence loginBonusSequence)
    {
    }

    [Token(Token = "0x6003E3E")]
    [Address(RVA = "0x2C14200", Offset = "0x2C14200", VA = "0x2C14200")]
    private ILoginBonusSequence Dequeue() => (ILoginBonusSequence) null;

    [Token(Token = "0x6003E3F")]
    [Address(RVA = "0x2C14640", Offset = "0x2C14640", VA = "0x2C14640")]
    private ILoginBonusSequence GetNextSequence() => (ILoginBonusSequence) null;

    [Token(Token = "0x6003E40")]
    [Address(RVA = "0x2C1470C", Offset = "0x2C1470C", VA = "0x2C1470C")]
    public LoginBonusSequencePlayer()
    {
    }
  }
}
