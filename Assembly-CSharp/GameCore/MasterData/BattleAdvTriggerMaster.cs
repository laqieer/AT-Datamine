// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleAdvTriggerMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DFB")]
  [Serializable]
  public sealed class BattleAdvTriggerMaster : BaseMaster<BattleAdvTriggerData>
  {
    [Token(Token = "0x40042C7")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleAdvTriggerData>> mapData;

    [Token(Token = "0x6005546")]
    [Address(RVA = "0x3AAEC3C", Offset = "0x3AAEC3C", VA = "0x3AAEC3C")]
    public IReadOnlyDictionary<int, BattleAdvTriggerData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleAdvTriggerData>) null;
    }

    [Token(Token = "0x6005547")]
    [Address(RVA = "0x3AAEC44", Offset = "0x3AAEC44", VA = "0x3AAEC44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005548")]
    [Address(RVA = "0x3AAECA4", Offset = "0x3AAECA4", VA = "0x3AAECA4", Slot = "5")]
    protected override BattleAdvTriggerData LoadEntity(IMasterDataReader reader)
    {
      return (BattleAdvTriggerData) null;
    }

    [Token(Token = "0x6005549")]
    [Address(RVA = "0x3AAED14", Offset = "0x3AAED14", VA = "0x3AAED14")]
    private void OnLoadEntity(BattleAdvTriggerData entity)
    {
    }

    [Token(Token = "0x600554A")]
    [Address(RVA = "0x3AAC0E8", Offset = "0x3AAC0E8", VA = "0x3AAC0E8")]
    public IReadOnlyList<BattleAdvTriggerData> GetListByGroupID(int groupId)
    {
      return (IReadOnlyList<BattleAdvTriggerData>) null;
    }

    [Token(Token = "0x600554B")]
    [Address(RVA = "0x3AAEE90", Offset = "0x3AAEE90", VA = "0x3AAEE90")]
    public BattleAdvTriggerMaster()
    {
    }
  }
}
