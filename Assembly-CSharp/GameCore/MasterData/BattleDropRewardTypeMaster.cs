// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropRewardTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EC1")]
  [Serializable]
  public sealed class BattleDropRewardTypeMaster : BaseMaster<BattleDropRewardTypeData>
  {
    [Token(Token = "0x6005931")]
    [Address(RVA = "0x3C30C40", Offset = "0x3C30C40", VA = "0x3C30C40")]
    public IReadOnlyDictionary<int, BattleDropRewardTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDropRewardTypeData>) null;
    }

    [Token(Token = "0x6005932")]
    [Address(RVA = "0x3C30C48", Offset = "0x3C30C48", VA = "0x3C30C48", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005933")]
    [Address(RVA = "0x3C30CA8", Offset = "0x3C30CA8", VA = "0x3C30CA8", Slot = "5")]
    protected override BattleDropRewardTypeData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDropRewardTypeData) null;
    }

    [Token(Token = "0x6005934")]
    [Address(RVA = "0x3C30D00", Offset = "0x3C30D00", VA = "0x3C30D00")]
    public BattleDropRewardTypeMaster()
    {
    }
  }
}
