// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildLevelRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001017")]
  [Serializable]
  public sealed class GuildLevelRewardMaster : BaseMaster<GuildLevelRewardData>
  {
    [Token(Token = "0x6005DB6")]
    [Address(RVA = "0x2796230", Offset = "0x2796230", VA = "0x2796230")]
    public IReadOnlyDictionary<int, GuildLevelRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildLevelRewardData>) null;
    }

    [Token(Token = "0x6005DB7")]
    [Address(RVA = "0x2796238", Offset = "0x2796238", VA = "0x2796238", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DB8")]
    [Address(RVA = "0x2796298", Offset = "0x2796298", VA = "0x2796298", Slot = "5")]
    protected override GuildLevelRewardData LoadEntity(IMasterDataReader reader)
    {
      return (GuildLevelRewardData) null;
    }

    [Token(Token = "0x6005DB9")]
    [Address(RVA = "0x27962F0", Offset = "0x27962F0", VA = "0x27962F0")]
    public List<GuildLevelRewardData> GetList() => (List<GuildLevelRewardData>) null;

    [Token(Token = "0x6005DBA")]
    [Address(RVA = "0x279635C", Offset = "0x279635C", VA = "0x279635C")]
    public GuildLevelRewardData GetLevelRewardDataWithLevel(int level)
    {
      return (GuildLevelRewardData) null;
    }

    [Token(Token = "0x6005DBB")]
    [Address(RVA = "0x27964FC", Offset = "0x27964FC", VA = "0x27964FC")]
    public int GetMemberMaxWithLevel(int level) => new int();

    [Token(Token = "0x6005DBC")]
    [Address(RVA = "0x2796518", Offset = "0x2796518", VA = "0x2796518")]
    public GuildLevelRewardMaster()
    {
    }
  }
}
