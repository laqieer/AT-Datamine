// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleVoiceCombiMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2A")]
  [Serializable]
  public sealed class BattleVoiceCombiMaster : BaseMaster<BattleVoiceCombiData>
  {
    [Token(Token = "0x600564E")]
    [Address(RVA = "0x3E34D54", Offset = "0x3E34D54", VA = "0x3E34D54")]
    public IReadOnlyDictionary<int, BattleVoiceCombiData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleVoiceCombiData>) null;
    }

    [Token(Token = "0x600564F")]
    [Address(RVA = "0x3E34D5C", Offset = "0x3E34D5C", VA = "0x3E34D5C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005650")]
    [Address(RVA = "0x3E34DBC", Offset = "0x3E34DBC", VA = "0x3E34DBC", Slot = "5")]
    protected override BattleVoiceCombiData LoadEntity(IMasterDataReader reader)
    {
      return (BattleVoiceCombiData) null;
    }

    [Token(Token = "0x6005651")]
    [Address(RVA = "0x3E34E14", Offset = "0x3E34E14", VA = "0x3E34E14")]
    public BattleVoiceCombiMaster()
    {
    }
  }
}
