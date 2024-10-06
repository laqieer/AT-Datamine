// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbySettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200108A")]
  [Serializable]
  public sealed class LobbySettingMaster : BaseMaster<LobbySettingData>
  {
    [Token(Token = "0x6005FE5")]
    [Address(RVA = "0x28D2D20", Offset = "0x28D2D20", VA = "0x28D2D20")]
    public IReadOnlyDictionary<int, LobbySettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbySettingData>) null;
    }

    [Token(Token = "0x6005FE6")]
    [Address(RVA = "0x28D2D28", Offset = "0x28D2D28", VA = "0x28D2D28", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FE7")]
    [Address(RVA = "0x28D2D88", Offset = "0x28D2D88", VA = "0x28D2D88", Slot = "5")]
    protected override LobbySettingData LoadEntity(IMasterDataReader reader)
    {
      return (LobbySettingData) null;
    }

    [Token(Token = "0x6005FE8")]
    [Address(RVA = "0x28D2DE0", Offset = "0x28D2DE0", VA = "0x28D2DE0")]
    public IEnumerable<LobbySettingData> GetList() => (IEnumerable<LobbySettingData>) null;

    [Token(Token = "0x6005FE9")]
    [Address(RVA = "0x28D2E30", Offset = "0x28D2E30", VA = "0x28D2E30")]
    public LobbySettingMaster()
    {
    }
  }
}
