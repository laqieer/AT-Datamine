// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerTitleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C4")]
  [Serializable]
  public sealed class PlayerTitleMaster : BaseMaster<PlayerTitleData>
  {
    [Token(Token = "0x4005254")]
    public const string TEXT_AB = "text_masterdata_player";

    [Token(Token = "0x60060E9")]
    [Address(RVA = "0x28DB8A4", Offset = "0x28DB8A4", VA = "0x28DB8A4")]
    public IReadOnlyDictionary<int, PlayerTitleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PlayerTitleData>) null;
    }

    [Token(Token = "0x60060EA")]
    [Address(RVA = "0x28DB8AC", Offset = "0x28DB8AC", VA = "0x28DB8AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060EB")]
    [Address(RVA = "0x28DB90C", Offset = "0x28DB90C", VA = "0x28DB90C", Slot = "5")]
    protected override PlayerTitleData LoadEntity(IMasterDataReader reader)
    {
      return (PlayerTitleData) null;
    }

    [Token(Token = "0x60060EC")]
    [Address(RVA = "0x28DB964", Offset = "0x28DB964", VA = "0x28DB964")]
    public IEnumerable<PlayerTitleData> GetAll() => (IEnumerable<PlayerTitleData>) null;

    [Token(Token = "0x60060ED")]
    [Address(RVA = "0x28DB9B4", Offset = "0x28DB9B4", VA = "0x28DB9B4")]
    public PlayerTitleMaster()
    {
    }
  }
}
