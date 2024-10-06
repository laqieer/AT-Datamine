// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFaclityInvestRateMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FEC")]
  [Serializable]
  public sealed class GuildFaclityInvestRateMaster : BaseMaster<GuildFaclityInvestRateData>
  {
    [Token(Token = "0x6005CF7")]
    [Address(RVA = "0x278FD6C", Offset = "0x278FD6C", VA = "0x278FD6C")]
    public IReadOnlyDictionary<int, GuildFaclityInvestRateData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFaclityInvestRateData>) null;
    }

    [Token(Token = "0x6005CF8")]
    [Address(RVA = "0x278FD74", Offset = "0x278FD74", VA = "0x278FD74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CF9")]
    [Address(RVA = "0x278FDD4", Offset = "0x278FDD4", VA = "0x278FDD4", Slot = "5")]
    protected override GuildFaclityInvestRateData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFaclityInvestRateData) null;
    }

    [Token(Token = "0x6005CFA")]
    [Address(RVA = "0x278FE2C", Offset = "0x278FE2C", VA = "0x278FE2C")]
    public List<GuildFaclityInvestRateData> GetFaclityInvestRateList()
    {
      return (List<GuildFaclityInvestRateData>) null;
    }

    [Token(Token = "0x6005CFB")]
    [Address(RVA = "0x278FE98", Offset = "0x278FE98", VA = "0x278FE98")]
    public GuildFaclityInvestRateMaster()
    {
    }
  }
}
