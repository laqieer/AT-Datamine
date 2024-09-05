// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001357")]
  [Serializable]
  public sealed class AbilityBoardRewardGroupMaster : BaseMaster<AbilityBoardRewardGroupData>
  {
    [Token(Token = "0x6006CF9")]
    [Address(RVA = "0x46F8734", Offset = "0x46F8734", VA = "0x46F8734")]
    public IReadOnlyDictionary<int, AbilityBoardRewardGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardRewardGroupData>) null;
    }

    [Token(Token = "0x6006CFA")]
    [Address(RVA = "0x46F873C", Offset = "0x46F873C", VA = "0x46F873C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CFB")]
    [Address(RVA = "0x46F879C", Offset = "0x46F879C", VA = "0x46F879C", Slot = "5")]
    protected override AbilityBoardRewardGroupData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardRewardGroupData) null;
    }

    [Token(Token = "0x6006CFC")]
    [Address(RVA = "0x46F87F4", Offset = "0x46F87F4", VA = "0x46F87F4")]
    public AbilityBoardRewardGroupMaster()
    {
    }
  }
}
