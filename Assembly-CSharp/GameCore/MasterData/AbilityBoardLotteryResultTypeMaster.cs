// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardLotteryResultTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200134E")]
  [Serializable]
  public sealed class AbilityBoardLotteryResultTypeMaster : 
    BaseMaster<AbilityBoardLotteryResultTypeData>
  {
    [Token(Token = "0x6006CD2")]
    [Address(RVA = "0x46F741C", Offset = "0x46F741C", VA = "0x46F741C")]
    public IReadOnlyDictionary<int, AbilityBoardLotteryResultTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardLotteryResultTypeData>) null;
    }

    [Token(Token = "0x6006CD3")]
    [Address(RVA = "0x46F7424", Offset = "0x46F7424", VA = "0x46F7424", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CD4")]
    [Address(RVA = "0x46F7484", Offset = "0x46F7484", VA = "0x46F7484", Slot = "5")]
    protected override AbilityBoardLotteryResultTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardLotteryResultTypeData) null;
    }

    [Token(Token = "0x6006CD5")]
    [Address(RVA = "0x46F74DC", Offset = "0x46F74DC", VA = "0x46F74DC")]
    public AbilityBoardLotteryResultTypeMaster()
    {
    }
  }
}
