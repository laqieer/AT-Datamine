// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionRapidCoinRequiredAmountMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA5")]
  [Serializable]
  public sealed class ExpeditionRapidCoinRequiredAmountMaster : 
    BaseMaster<ExpeditionRapidCoinRequiredAmountData>
  {
    [Token(Token = "0x6005BDD")]
    [Address(RVA = "0x2786DFC", Offset = "0x2786DFC", VA = "0x2786DFC")]
    public IReadOnlyDictionary<int, ExpeditionRapidCoinRequiredAmountData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionRapidCoinRequiredAmountData>) null;
    }

    [Token(Token = "0x6005BDE")]
    [Address(RVA = "0x2786E04", Offset = "0x2786E04", VA = "0x2786E04", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BDF")]
    [Address(RVA = "0x2786E64", Offset = "0x2786E64", VA = "0x2786E64", Slot = "5")]
    protected override ExpeditionRapidCoinRequiredAmountData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionRapidCoinRequiredAmountData) null;
    }

    [Token(Token = "0x6005BE0")]
    [Address(RVA = "0x2786EBC", Offset = "0x2786EBC", VA = "0x2786EBC")]
    public ExpeditionRapidCoinRequiredAmountMaster()
    {
    }
  }
}
