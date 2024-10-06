// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildArmourySettingsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB9")]
  [Serializable]
  public sealed class GuildArmourySettingsMaster : BaseMaster<GuildArmourySettingsData>
  {
    [Token(Token = "0x6005C3F")]
    [Address(RVA = "0x278A728", Offset = "0x278A728", VA = "0x278A728")]
    public IReadOnlyDictionary<int, GuildArmourySettingsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildArmourySettingsData>) null;
    }

    [Token(Token = "0x6005C40")]
    [Address(RVA = "0x278A730", Offset = "0x278A730", VA = "0x278A730", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C41")]
    [Address(RVA = "0x278A790", Offset = "0x278A790", VA = "0x278A790", Slot = "5")]
    protected override GuildArmourySettingsData LoadEntity(IMasterDataReader reader)
    {
      return (GuildArmourySettingsData) null;
    }

    [Token(Token = "0x6005C42")]
    [Address(RVA = "0x278A7E8", Offset = "0x278A7E8", VA = "0x278A7E8")]
    public GuildArmourySettingsMaster()
    {
    }
  }
}
