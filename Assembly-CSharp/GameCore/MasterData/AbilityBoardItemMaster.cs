// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103A")]
  [Serializable]
  public sealed class AbilityBoardItemMaster : BaseMaster<AbilityBoardItemData>
  {
    [Token(Token = "0x4005074")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005E4D")]
    [Address(RVA = "0x28C22EC", Offset = "0x28C22EC", VA = "0x28C22EC")]
    public IReadOnlyDictionary<int, AbilityBoardItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardItemData>) null;
    }

    [Token(Token = "0x6005E4E")]
    [Address(RVA = "0x28C22F4", Offset = "0x28C22F4", VA = "0x28C22F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E4F")]
    [Address(RVA = "0x28C2354", Offset = "0x28C2354", VA = "0x28C2354", Slot = "5")]
    protected override AbilityBoardItemData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardItemData) null;
    }

    [Token(Token = "0x6005E50")]
    [Address(RVA = "0x28C23AC", Offset = "0x28C23AC", VA = "0x28C23AC")]
    public AbilityBoardItemMaster()
    {
    }
  }
}
