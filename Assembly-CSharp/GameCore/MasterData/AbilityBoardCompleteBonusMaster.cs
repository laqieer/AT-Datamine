// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCompleteBonusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200132E")]
  [Serializable]
  public sealed class AbilityBoardCompleteBonusMaster : BaseMaster<AbilityBoardCompleteBonusData>
  {
    [Token(Token = "0x6006C3D")]
    [Address(RVA = "0x46F1BB4", Offset = "0x46F1BB4", VA = "0x46F1BB4")]
    public IReadOnlyDictionary<int, AbilityBoardCompleteBonusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardCompleteBonusData>) null;
    }

    [Token(Token = "0x6006C3E")]
    [Address(RVA = "0x46F1BBC", Offset = "0x46F1BBC", VA = "0x46F1BBC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C3F")]
    [Address(RVA = "0x46F1C1C", Offset = "0x46F1C1C", VA = "0x46F1C1C", Slot = "5")]
    protected override AbilityBoardCompleteBonusData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardCompleteBonusData) null;
    }

    [Token(Token = "0x6006C40")]
    [Address(RVA = "0x46F1C74", Offset = "0x46F1C74", VA = "0x46F1C74")]
    public AbilityBoardCompleteBonusMaster()
    {
    }
  }
}
