// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTriggerConditionDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C1")]
  [Serializable]
  public sealed class SkillTriggerConditionDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4005573")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005574")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005575")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum op;
    [Token(Token = "0x4005576")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public SkillTriggerConditionTypeEnum condition;
    [Token(Token = "0x4005577")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int threshold;

    [Token(Token = "0x17000F56")]
    public int Key
    {
      [Token(Token = "0x60065A6"), Address(RVA = "0x4D1DCA8", Offset = "0x4D1DCA8", VA = "0x4D1DCA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065A7")]
    [Address(RVA = "0x4D1DCB0", Offset = "0x4D1DCB0", VA = "0x4D1DCB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065A8")]
    [Address(RVA = "0x4D1DEDC", Offset = "0x4D1DEDC", VA = "0x4D1DEDC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60065A9")]
    [Address(RVA = "0x4D1DF90", Offset = "0x4D1DF90", VA = "0x4D1DF90")]
    public SkillTriggerConditionDetailData()
    {
    }
  }
}
