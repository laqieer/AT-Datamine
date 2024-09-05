// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001336")]
  [Serializable]
  public sealed class AbilityBoardConsumeItemMaster : BaseMaster<AbilityBoardConsumeItemData>
  {
    [Token(Token = "0x6006C63")]
    [Address(RVA = "0x46F31F4", Offset = "0x46F31F4", VA = "0x46F31F4")]
    public IReadOnlyDictionary<int, AbilityBoardConsumeItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardConsumeItemData>) null;
    }

    [Token(Token = "0x6006C64")]
    [Address(RVA = "0x46F31FC", Offset = "0x46F31FC", VA = "0x46F31FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C65")]
    [Address(RVA = "0x46F325C", Offset = "0x46F325C", VA = "0x46F325C", Slot = "5")]
    protected override AbilityBoardConsumeItemData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardConsumeItemData) null;
    }

    [Token(Token = "0x6006C66")]
    [Address(RVA = "0x46F32B4", Offset = "0x46F32B4", VA = "0x46F32B4")]
    public AbilityBoardConsumeItemMaster()
    {
    }
  }
}
