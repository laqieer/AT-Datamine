// Decompiled with JetBrains decompiler
// Type: Battle.Data.ConditionDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200274C")]
  public class ConditionDetail
  {
    [Token(Token = "0x600F50B")]
    [Address(RVA = "0x1FB2F84", Offset = "0x1FB2F84", VA = "0x1FB2F84")]
    public ConditionDetail(
      ConditionOpTypeEnum op,
      ConditionTargetTypeEnum conditionTarget,
      IReadOnlyList<SkillTriggerConditionDetailData> data)
    {
    }

    [Token(Token = "0x17003461")]
    public ConditionOpTypeEnum Op
    {
      [Token(Token = "0x600F50C"), Address(RVA = "0x1FB2FC0", Offset = "0x1FB2FC0", VA = "0x1FB2FC0")] get
      {
        return new ConditionOpTypeEnum();
      }
      [Token(Token = "0x600F50D"), Address(RVA = "0x1FB2FC8", Offset = "0x1FB2FC8", VA = "0x1FB2FC8")] protected set
      {
      }
    }

    [Token(Token = "0x17003462")]
    public ConditionTargetTypeEnum ConditionTarget
    {
      [Token(Token = "0x600F50E"), Address(RVA = "0x1FB2FD0", Offset = "0x1FB2FD0", VA = "0x1FB2FD0")] get
      {
        return new ConditionTargetTypeEnum();
      }
      [Token(Token = "0x600F50F"), Address(RVA = "0x1FB2FD8", Offset = "0x1FB2FD8", VA = "0x1FB2FD8")] protected set
      {
      }
    }

    [Token(Token = "0x17003463")]
    public IReadOnlyList<SkillTriggerConditionDetailData> ConditionDetails
    {
      [Token(Token = "0x600F510"), Address(RVA = "0x1FB2FE0", Offset = "0x1FB2FE0", VA = "0x1FB2FE0")] get
      {
        return (IReadOnlyList<SkillTriggerConditionDetailData>) null;
      }
      [Token(Token = "0x600F511"), Address(RVA = "0x1FB2FE8", Offset = "0x1FB2FE8", VA = "0x1FB2FE8")] protected set
      {
      }
    }

    [Token(Token = "0x600F512")]
    [Address(RVA = "0x1FB2FF0", Offset = "0x1FB2FF0", VA = "0x1FB2FF0")]
    public bool IsMatchCondition(ConditionParam condition) => new bool();
  }
}
