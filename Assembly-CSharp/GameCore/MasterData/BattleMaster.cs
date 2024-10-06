// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E28")]
  [Serializable]
  public sealed class BattleMaster : BaseMaster<BattleData>
  {
    [Token(Token = "0x4004376")]
    public const string TEXT_AB = "text_masterdata_battle";

    [Token(Token = "0x6005643")]
    [Address(RVA = "0x3E337B0", Offset = "0x3E337B0", VA = "0x3E337B0")]
    public IReadOnlyDictionary<int, BattleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleData>) null;
    }

    [Token(Token = "0x6005644")]
    [Address(RVA = "0x3E337B8", Offset = "0x3E337B8", VA = "0x3E337B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005645")]
    [Address(RVA = "0x3E33818", Offset = "0x3E33818", VA = "0x3E33818", Slot = "5")]
    protected override BattleData LoadEntity(IMasterDataReader reader) => (BattleData) null;

    [Token(Token = "0x6005646")]
    [Address(RVA = "0x3E33870", Offset = "0x3E33870", VA = "0x3E33870")]
    public BattleMaster()
    {
    }
  }
}
