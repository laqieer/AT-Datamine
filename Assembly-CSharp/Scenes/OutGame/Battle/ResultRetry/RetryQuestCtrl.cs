// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.RetryQuestCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037C8")]
  public class RetryQuestCtrl
  {
    [Token(Token = "0x400F3CF")]
    [FieldOffset(Offset = "0x20")]
    private QuestInfo _questInfo;

    [Token(Token = "0x1700489D")]
    public Action<string> OnError
    {
      [Token(Token = "0x6015F4B"), Address(RVA = "0x232BE94", Offset = "0x232BE94", VA = "0x232BE94")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6015F4C"), Address(RVA = "0x232BE9C", Offset = "0x232BE9C", VA = "0x232BE9C")] set
      {
      }
    }

    [Token(Token = "0x1700489E")]
    public bool Executable
    {
      [Token(Token = "0x6015F4D"), Address(RVA = "0x232BEA4", Offset = "0x232BEA4", VA = "0x232BEA4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015F4E"), Address(RVA = "0x232BEAC", Offset = "0x232BEAC", VA = "0x232BEAC")] private set
      {
      }
    }

    [Token(Token = "0x1700489F")]
    public bool OccupancyProcessing
    {
      [Token(Token = "0x6015F4F"), Address(RVA = "0x232AC70", Offset = "0x232AC70", VA = "0x232AC70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015F50")]
    [Address(RVA = "0x232AFB8", Offset = "0x232AFB8", VA = "0x232AFB8")]
    public RetryQuestCtrl(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6015F51")]
    [Address(RVA = "0x232AFE8", Offset = "0x232AFE8", VA = "0x232AFE8")]
    public IEnumerator ExecAsync() => (IEnumerator) null;
  }
}
