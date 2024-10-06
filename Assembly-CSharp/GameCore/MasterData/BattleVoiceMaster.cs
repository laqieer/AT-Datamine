// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleVoiceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2C")]
  [Serializable]
  public sealed class BattleVoiceMaster : BaseMaster<BattleVoiceData>
  {
    [Token(Token = "0x6005656")]
    [Address(RVA = "0x3E35158", Offset = "0x3E35158", VA = "0x3E35158")]
    public IReadOnlyDictionary<int, BattleVoiceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleVoiceData>) null;
    }

    [Token(Token = "0x6005657")]
    [Address(RVA = "0x3E35160", Offset = "0x3E35160", VA = "0x3E35160", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005658")]
    [Address(RVA = "0x3E351C0", Offset = "0x3E351C0", VA = "0x3E351C0", Slot = "5")]
    protected override BattleVoiceData LoadEntity(IMasterDataReader reader)
    {
      return (BattleVoiceData) null;
    }

    [Token(Token = "0x6005659")]
    [Address(RVA = "0x3E35218", Offset = "0x3E35218", VA = "0x3E35218")]
    public BattleVoiceMaster()
    {
    }
  }
}
