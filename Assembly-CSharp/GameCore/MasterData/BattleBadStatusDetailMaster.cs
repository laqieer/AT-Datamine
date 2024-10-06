// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DFF")]
  [Serializable]
  public sealed class BattleBadStatusDetailMaster : BaseMaster<BattleBadStatusDetailData>
  {
    [Token(Token = "0x40042DC")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x40042DD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleBadStatusDetailData>> badStatusTypeMap;

    [Token(Token = "0x600555E")]
    [Address(RVA = "0x3AAFBD8", Offset = "0x3AAFBD8", VA = "0x3AAFBD8")]
    public IReadOnlyDictionary<int, BattleBadStatusDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleBadStatusDetailData>) null;
    }

    [Token(Token = "0x600555F")]
    [Address(RVA = "0x3AAFBE0", Offset = "0x3AAFBE0", VA = "0x3AAFBE0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005560")]
    [Address(RVA = "0x3AAFDB0", Offset = "0x3AAFDB0", VA = "0x3AAFDB0", Slot = "5")]
    protected override BattleBadStatusDetailData LoadEntity(IMasterDataReader reader)
    {
      return (BattleBadStatusDetailData) null;
    }

    [Token(Token = "0x6005561")]
    [Address(RVA = "0x3AAFE20", Offset = "0x3AAFE20", VA = "0x3AAFE20")]
    private void OnLoadEntity(BattleBadStatusDetailData entity)
    {
    }

    [Token(Token = "0x6005562")]
    [Address(RVA = "0x3AAFC48", Offset = "0x3AAFC48", VA = "0x3AAFC48")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6005563")]
    [Address(RVA = "0x3AB0210", Offset = "0x3AB0210", VA = "0x3AB0210")]
    public IReadOnlyList<BattleBadStatusDetailData> GetListByBadStatusType(
      BattleBadStatusTypeEnum type)
    {
      return (IReadOnlyList<BattleBadStatusDetailData>) null;
    }

    [Token(Token = "0x6005564")]
    [Address(RVA = "0x3AB02D0", Offset = "0x3AB02D0", VA = "0x3AB02D0")]
    public BattleBadStatusDetailMaster()
    {
    }
  }
}
