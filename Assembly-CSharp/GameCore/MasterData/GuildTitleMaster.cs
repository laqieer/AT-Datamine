// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildTitleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200100F")]
  [Serializable]
  public sealed class GuildTitleMaster : BaseMaster<GuildTitleData>
  {
    [Token(Token = "0x4004FF3")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005D8B")]
    [Address(RVA = "0x2794C40", Offset = "0x2794C40", VA = "0x2794C40")]
    public IReadOnlyDictionary<int, GuildTitleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildTitleData>) null;
    }

    [Token(Token = "0x6005D8C")]
    [Address(RVA = "0x2794C48", Offset = "0x2794C48", VA = "0x2794C48", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D8D")]
    [Address(RVA = "0x2794CA8", Offset = "0x2794CA8", VA = "0x2794CA8", Slot = "5")]
    protected override GuildTitleData LoadEntity(IMasterDataReader reader) => (GuildTitleData) null;

    [Token(Token = "0x6005D8E")]
    [Address(RVA = "0x2794D00", Offset = "0x2794D00", VA = "0x2794D00")]
    public IEnumerable<GuildTitleData> GetAll() => (IEnumerable<GuildTitleData>) null;

    [Token(Token = "0x6005D8F")]
    [Address(RVA = "0x2794D50", Offset = "0x2794D50", VA = "0x2794D50")]
    public GuildTitleMaster()
    {
    }
  }
}
