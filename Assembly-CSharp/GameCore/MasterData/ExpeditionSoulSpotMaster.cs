// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulSpotMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA9")]
  [Serializable]
  public sealed class ExpeditionSoulSpotMaster : BaseMaster<ExpeditionSoulSpotData>
  {
    [Token(Token = "0x6005BED")]
    [Address(RVA = "0x278765C", Offset = "0x278765C", VA = "0x278765C")]
    public IReadOnlyDictionary<int, ExpeditionSoulSpotData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionSoulSpotData>) null;
    }

    [Token(Token = "0x6005BEE")]
    [Address(RVA = "0x2787664", Offset = "0x2787664", VA = "0x2787664", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BEF")]
    [Address(RVA = "0x27876C4", Offset = "0x27876C4", VA = "0x27876C4", Slot = "5")]
    protected override ExpeditionSoulSpotData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionSoulSpotData) null;
    }

    [Token(Token = "0x6005BF0")]
    [Address(RVA = "0x278771C", Offset = "0x278771C", VA = "0x278771C")]
    public ExpeditionSoulSpotMaster()
    {
    }
  }
}
