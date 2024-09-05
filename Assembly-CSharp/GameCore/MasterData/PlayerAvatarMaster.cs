// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerAvatarMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BC")]
  [Serializable]
  public sealed class PlayerAvatarMaster : BaseMaster<PlayerAvatarData>
  {
    [Token(Token = "0x400523D")]
    public const string TEXT_AB = "text_masterdata_player";

    [Token(Token = "0x60060C2")]
    [Address(RVA = "0x28DA3F0", Offset = "0x28DA3F0", VA = "0x28DA3F0")]
    public IReadOnlyDictionary<int, PlayerAvatarData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PlayerAvatarData>) null;
    }

    [Token(Token = "0x60060C3")]
    [Address(RVA = "0x28DA3F8", Offset = "0x28DA3F8", VA = "0x28DA3F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060C4")]
    [Address(RVA = "0x28DA458", Offset = "0x28DA458", VA = "0x28DA458", Slot = "5")]
    protected override PlayerAvatarData LoadEntity(IMasterDataReader reader)
    {
      return (PlayerAvatarData) null;
    }

    [Token(Token = "0x60060C5")]
    [Address(RVA = "0x28DA4B0", Offset = "0x28DA4B0", VA = "0x28DA4B0")]
    public PlayerAvatarMaster()
    {
    }
  }
}
