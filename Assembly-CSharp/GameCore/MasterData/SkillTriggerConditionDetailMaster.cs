// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTriggerConditionDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C0")]
  [Serializable]
  public sealed class SkillTriggerConditionDetailMaster : BaseMaster<SkillTriggerConditionDetailData>
  {
    [Token(Token = "0x4005572")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SkillTriggerConditionDetailData>> dataMap;

    [Token(Token = "0x60065A0")]
    [Address(RVA = "0x4D1D904", Offset = "0x4D1D904", VA = "0x4D1D904")]
    public IReadOnlyDictionary<int, SkillTriggerConditionDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillTriggerConditionDetailData>) null;
    }

    [Token(Token = "0x60065A1")]
    [Address(RVA = "0x4D1D90C", Offset = "0x4D1D90C", VA = "0x4D1D90C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065A2")]
    [Address(RVA = "0x4D1D96C", Offset = "0x4D1D96C", VA = "0x4D1D96C", Slot = "5")]
    protected override SkillTriggerConditionDetailData LoadEntity(IMasterDataReader reader)
    {
      return (SkillTriggerConditionDetailData) null;
    }

    [Token(Token = "0x60065A3")]
    [Address(RVA = "0x4D1D9DC", Offset = "0x4D1D9DC", VA = "0x4D1D9DC")]
    private void OnLoadEntity(SkillTriggerConditionDetailData entity)
    {
    }

    [Token(Token = "0x60065A4")]
    [Address(RVA = "0x4D1DB58", Offset = "0x4D1DB58", VA = "0x4D1DB58")]
    public List<SkillTriggerConditionDetailData> GetListByGroupID(int id)
    {
      return (List<SkillTriggerConditionDetailData>) null;
    }

    [Token(Token = "0x60065A5")]
    [Address(RVA = "0x4D1DC18", Offset = "0x4D1DC18", VA = "0x4D1DC18")]
    public SkillTriggerConditionDetailMaster()
    {
    }
  }
}
