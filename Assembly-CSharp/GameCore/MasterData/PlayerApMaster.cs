// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerApMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BA")]
  [Serializable]
  public sealed class PlayerApMaster : BaseMaster<PlayerApData>
  {
    [Token(Token = "0x60060B8")]
    [Address(RVA = "0x28D9EEC", Offset = "0x28D9EEC", VA = "0x28D9EEC")]
    public IReadOnlyDictionary<int, PlayerApData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PlayerApData>) null;
    }

    [Token(Token = "0x60060B9")]
    [Address(RVA = "0x28D9EF4", Offset = "0x28D9EF4", VA = "0x28D9EF4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060BA")]
    [Address(RVA = "0x28D9F54", Offset = "0x28D9F54", VA = "0x28D9F54", Slot = "5")]
    protected override PlayerApData LoadEntity(IMasterDataReader reader) => (PlayerApData) null;

    [Token(Token = "0x60060BB")]
    [Address(RVA = "0x28D9FAC", Offset = "0x28D9FAC", VA = "0x28D9FAC")]
    public PlayerApData GetDataByDayRecoveryCount(int recoveryCount) => (PlayerApData) null;

    [Token(Token = "0x60060BC")]
    [Address(RVA = "0x28DA130", Offset = "0x28DA130", VA = "0x28DA130")]
    public int GetNeedCoin(int dayRecoveryCount, int recoveryCount) => new int();

    [Token(Token = "0x60060BD")]
    [Address(RVA = "0x28DA198", Offset = "0x28DA198", VA = "0x28DA198")]
    public PlayerApMaster()
    {
    }
  }
}
