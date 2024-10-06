// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200135E")]
  [Serializable]
  public sealed class AbilityBoardMaster : BaseMaster<AbilityBoardData>
  {
    [Token(Token = "0x6006D19")]
    [Address(RVA = "0x46F9E78", Offset = "0x46F9E78", VA = "0x46F9E78")]
    public IReadOnlyDictionary<int, AbilityBoardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardData>) null;
    }

    [Token(Token = "0x6006D1A")]
    [Address(RVA = "0x46F9E80", Offset = "0x46F9E80", VA = "0x46F9E80", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D1B")]
    [Address(RVA = "0x46F9EE0", Offset = "0x46F9EE0", VA = "0x46F9EE0", Slot = "5")]
    protected override AbilityBoardData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardData) null;
    }

    [Token(Token = "0x6006D1C")]
    [Address(RVA = "0x46F9F38", Offset = "0x46F9F38", VA = "0x46F9F38")]
    public IReadOnlyCollection<AbilityBoardData> GetList()
    {
      return (IReadOnlyCollection<AbilityBoardData>) null;
    }

    [Token(Token = "0x6006D1D")]
    [Address(RVA = "0x46F9F88", Offset = "0x46F9F88", VA = "0x46F9F88")]
    public IReadOnlyList<AbilityBoardData> GetListByBoardListId(int listId)
    {
      return (IReadOnlyList<AbilityBoardData>) null;
    }

    [Token(Token = "0x6006D1E")]
    [Address(RVA = "0x46FA1BC", Offset = "0x46FA1BC", VA = "0x46FA1BC")]
    public AbilityBoardMaster()
    {
    }
  }
}
