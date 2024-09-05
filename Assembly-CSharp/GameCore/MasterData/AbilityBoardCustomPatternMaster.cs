// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCustomPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001347")]
  [Serializable]
  public sealed class AbilityBoardCustomPatternMaster : BaseMaster<AbilityBoardCustomPatternData>
  {
    [Token(Token = "0x6006CB3")]
    [Address(RVA = "0x46F6488", Offset = "0x46F6488", VA = "0x46F6488")]
    public IReadOnlyDictionary<int, AbilityBoardCustomPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardCustomPatternData>) null;
    }

    [Token(Token = "0x6006CB4")]
    [Address(RVA = "0x46F6490", Offset = "0x46F6490", VA = "0x46F6490", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CB5")]
    [Address(RVA = "0x46F64F0", Offset = "0x46F64F0", VA = "0x46F64F0", Slot = "5")]
    protected override AbilityBoardCustomPatternData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardCustomPatternData) null;
    }

    [Token(Token = "0x6006CB6")]
    [Address(RVA = "0x46F6548", Offset = "0x46F6548", VA = "0x46F6548")]
    public AbilityBoardCustomPatternMaster()
    {
    }
  }
}
