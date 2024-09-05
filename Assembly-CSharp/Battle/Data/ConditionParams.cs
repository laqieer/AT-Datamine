// Decompiled with JetBrains decompiler
// Type: Battle.Data.ConditionParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200274A")]
  public class ConditionParams : ConditionParam
  {
    [Token(Token = "0x400A7DE")]
    [FieldOffset(Offset = "0x48")]
    private System.Collections.Generic.List<ConditionParam> list;

    [Token(Token = "0x1700345C")]
    public IReadOnlyList<ConditionParam> List
    {
      [Token(Token = "0x600F4EB"), Address(RVA = "0x1FB0E14", Offset = "0x1FB0E14", VA = "0x1FB0E14")] get
      {
        return (IReadOnlyList<ConditionParam>) null;
      }
    }

    [Token(Token = "0x600F4EC")]
    [Address(RVA = "0x1FB0E1C", Offset = "0x1FB0E1C", VA = "0x1FB0E1C")]
    public ConditionParams()
    {
    }

    [Token(Token = "0x600F4ED")]
    [Address(RVA = "0x1FB0EA8", Offset = "0x1FB0EA8", VA = "0x1FB0EA8")]
    public void Add(ConditionParam param)
    {
    }

    [Token(Token = "0x600F4EE")]
    [Address(RVA = "0x1FB0FF4", Offset = "0x1FB0FF4", VA = "0x1FB0FF4")]
    public bool IsEmpty() => new bool();

    [Token(Token = "0x600F4EF")]
    [Address(RVA = "0x1FB0F88", Offset = "0x1FB0F88", VA = "0x1FB0F88")]
    private bool Addable(ConditionParam param) => new bool();

    [Token(Token = "0x600F4F0")]
    [Address(RVA = "0x1FB1044", Offset = "0x1FB1044", VA = "0x1FB1044")]
    public void Remove(ConditionParam param)
    {
    }

    [Token(Token = "0x600F4F1")]
    [Address(RVA = "0x1FB109C", Offset = "0x1FB109C", VA = "0x1FB109C", Slot = "4")]
    public override void SetConditionTarget(ConditionTargetTypeEnum targetType)
    {
    }

    [Token(Token = "0x600F4F2")]
    [Address(RVA = "0x1FB11F8", Offset = "0x1FB11F8", VA = "0x1FB11F8", Slot = "5")]
    public override bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType)
    {
      return new bool();
    }

    [Token(Token = "0x600F4F3")]
    [Address(RVA = "0x1FB1368", Offset = "0x1FB1368", VA = "0x1FB1368", Slot = "6")]
    protected override bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail)
    {
      return new bool();
    }
  }
}
