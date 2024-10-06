// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200100A")]
  [Serializable]
  public sealed class GuildRaidMaster : BaseMaster<GuildRaidData>
  {
    [Token(Token = "0x6005D76")]
    [Address(RVA = "0x2793BD0", Offset = "0x2793BD0", VA = "0x2793BD0")]
    public IReadOnlyDictionary<int, GuildRaidData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidData>) null;
    }

    [Token(Token = "0x6005D77")]
    [Address(RVA = "0x2793BD8", Offset = "0x2793BD8", VA = "0x2793BD8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D78")]
    [Address(RVA = "0x2793C38", Offset = "0x2793C38", VA = "0x2793C38", Slot = "5")]
    protected override GuildRaidData LoadEntity(IMasterDataReader reader) => (GuildRaidData) null;

    [Token(Token = "0x6005D79")]
    [Address(RVA = "0x2793C90", Offset = "0x2793C90", VA = "0x2793C90")]
    public bool IsRaidBeingHeld() => new bool();

    [Token(Token = "0x6005D7A")]
    [Address(RVA = "0x2793DC8", Offset = "0x2793DC8", VA = "0x2793DC8")]
    public GuildRaidData GetOpenRaidData() => (GuildRaidData) null;

    [Token(Token = "0x6005D7B")]
    [Address(RVA = "0x2793FFC", Offset = "0x2793FFC", VA = "0x2793FFC")]
    public bool CheckRaidIsHeld(int raidId) => new bool();

    [Token(Token = "0x6005D7C")]
    [Address(RVA = "0x2794114", Offset = "0x2794114", VA = "0x2794114")]
    public GuildRaidMaster()
    {
    }
  }
}
