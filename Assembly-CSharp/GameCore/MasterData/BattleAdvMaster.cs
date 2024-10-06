// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleAdvMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF6")]
  [Serializable]
  public sealed class BattleAdvMaster : BaseMaster<BattleAdvData>
  {
    [Token(Token = "0x40042AA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleAdvData>> mapData;

    [Token(Token = "0x600551E")]
    [Address(RVA = "0x3AAB158", Offset = "0x3AAB158", VA = "0x3AAB158")]
    public IReadOnlyDictionary<int, BattleAdvData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleAdvData>) null;
    }

    [Token(Token = "0x600551F")]
    [Address(RVA = "0x3AAB160", Offset = "0x3AAB160", VA = "0x3AAB160", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005520")]
    [Address(RVA = "0x3AAB1C0", Offset = "0x3AAB1C0", VA = "0x3AAB1C0", Slot = "5")]
    protected override BattleAdvData LoadEntity(IMasterDataReader reader) => (BattleAdvData) null;

    [Token(Token = "0x6005521")]
    [Address(RVA = "0x3AAB230", Offset = "0x3AAB230", VA = "0x3AAB230")]
    private void OnLoadEntity(BattleAdvData entity)
    {
    }

    [Token(Token = "0x6005522")]
    [Address(RVA = "0x3AAB3AC", Offset = "0x3AAB3AC", VA = "0x3AAB3AC")]
    public IReadOnlyList<BattleAdvData> GetListByQuestID(int questId)
    {
      return (IReadOnlyList<BattleAdvData>) null;
    }

    [Token(Token = "0x6005523")]
    [Address(RVA = "0x3AAB46C", Offset = "0x3AAB46C", VA = "0x3AAB46C")]
    public BattleAdvMaster()
    {
    }
  }
}
