// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.AttentionDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.UI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025CF")]
  public class AttentionDirector : Battle.AttentionDirector
  {
    [Token(Token = "0x170031D5")]
    public override bool IsPlaying
    {
      [Token(Token = "0x600E967"), Address(RVA = "0x4C49DA0", Offset = "0x4C49DA0", VA = "0x4C49DA0", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E968")]
    [Address(RVA = "0x4C49DA8", Offset = "0x4C49DA8", VA = "0x4C49DA8", Slot = "12")]
    public override void PlaySystemAttention(AttentionTween.Mode mode, UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600E969")]
    [Address(RVA = "0x4C49DC0", Offset = "0x4C49DC0", VA = "0x4C49DC0", Slot = "13")]
    public override void PlayDefeatAttention(
      Sprite charaTexture,
      string charaName,
      UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600E96A")]
    [Address(RVA = "0x4C49DD8", Offset = "0x4C49DD8", VA = "0x4C49DD8", Slot = "14")]
    public override void PlayWithdrawalAttention(
      UnitParameterData unit,
      bool AutoBattlePauseUnitLost,
      bool enableLost,
      UnityAction onCompleted = null)
    {
    }

    [Token(Token = "0x600E96B")]
    [Address(RVA = "0x4C49DF0", Offset = "0x4C49DF0", VA = "0x4C49DF0", Slot = "9")]
    public override void InitializeDirection(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
    }

    [Token(Token = "0x600E96C")]
    [Address(RVA = "0x4C49DF4", Offset = "0x4C49DF4", VA = "0x4C49DF4", Slot = "10")]
    public override void FinishDirection(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
    }

    [Token(Token = "0x600E96D")]
    [Address(RVA = "0x4C49DF8", Offset = "0x4C49DF8", VA = "0x4C49DF8", Slot = "11")]
    public override bool IsDirectionInitialized(AttentionTween.Mode mode = AttentionTween.Mode.AllyPhase)
    {
      return new bool();
    }

    [Token(Token = "0x600E96E")]
    [Address(RVA = "0x4C49E00", Offset = "0x4C49E00", VA = "0x4C49E00")]
    public AttentionDirector()
    {
    }
  }
}
