// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001329")]
  [Serializable]
  public sealed class AbilityBoardBoardListMaster : BaseMaster<AbilityBoardBoardListData>
  {
    [Token(Token = "0x6006C25")]
    [Address(RVA = "0x46F0D2C", Offset = "0x46F0D2C", VA = "0x46F0D2C")]
    public IReadOnlyDictionary<int, AbilityBoardBoardListData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardBoardListData>) null;
    }

    [Token(Token = "0x6006C26")]
    [Address(RVA = "0x46F0D34", Offset = "0x46F0D34", VA = "0x46F0D34", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C27")]
    [Address(RVA = "0x46F0D94", Offset = "0x46F0D94", VA = "0x46F0D94", Slot = "5")]
    protected override AbilityBoardBoardListData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardBoardListData) null;
    }

    [Token(Token = "0x6006C28")]
    [Address(RVA = "0x46F0DEC", Offset = "0x46F0DEC", VA = "0x46F0DEC")]
    public AbilityBoardBoardListMaster()
    {
    }
  }
}
