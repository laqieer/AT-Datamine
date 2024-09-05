// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildBattleSettingsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001011")]
  [Serializable]
  public sealed class GuildBattleSettingsMaster : BaseMaster<GuildBattleSettingsData>
  {
    [Token(Token = "0x6005D9D")]
    [Address(RVA = "0x279532C", Offset = "0x279532C", VA = "0x279532C")]
    public IReadOnlyDictionary<int, GuildBattleSettingsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildBattleSettingsData>) null;
    }

    [Token(Token = "0x6005D9E")]
    [Address(RVA = "0x2795334", Offset = "0x2795334", VA = "0x2795334", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D9F")]
    [Address(RVA = "0x2795394", Offset = "0x2795394", VA = "0x2795394", Slot = "5")]
    protected override GuildBattleSettingsData LoadEntity(IMasterDataReader reader)
    {
      return (GuildBattleSettingsData) null;
    }

    [Token(Token = "0x6005DA0")]
    [Address(RVA = "0x27953EC", Offset = "0x27953EC", VA = "0x27953EC")]
    public GuildBattleSettingsMaster()
    {
    }
  }
}
