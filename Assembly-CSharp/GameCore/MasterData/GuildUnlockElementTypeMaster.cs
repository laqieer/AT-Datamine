// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildUnlockElementTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD1")]
  [Serializable]
  public sealed class GuildUnlockElementTypeMaster : BaseMaster<GuildUnlockElementTypeData>
  {
    [Token(Token = "0x4004F64")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C88")]
    [Address(RVA = "0x278C5F4", Offset = "0x278C5F4", VA = "0x278C5F4")]
    public IReadOnlyDictionary<int, GuildUnlockElementTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildUnlockElementTypeData>) null;
    }

    [Token(Token = "0x6005C89")]
    [Address(RVA = "0x278C5FC", Offset = "0x278C5FC", VA = "0x278C5FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C8A")]
    [Address(RVA = "0x278C65C", Offset = "0x278C65C", VA = "0x278C65C", Slot = "5")]
    protected override GuildUnlockElementTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildUnlockElementTypeData) null;
    }

    [Token(Token = "0x6005C8B")]
    [Address(RVA = "0x278C6B4", Offset = "0x278C6B4", VA = "0x278C6B4")]
    public GuildUnlockElementTypeMaster()
    {
    }
  }
}
