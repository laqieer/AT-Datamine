// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCustomPatternSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001345")]
  [Serializable]
  public sealed class AbilityBoardCustomPatternSettingMaster : 
    BaseMaster<AbilityBoardCustomPatternSettingData>
  {
    [Token(Token = "0x6006CAB")]
    [Address(RVA = "0x46F5F3C", Offset = "0x46F5F3C", VA = "0x46F5F3C")]
    public IReadOnlyDictionary<int, AbilityBoardCustomPatternSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardCustomPatternSettingData>) null;
    }

    [Token(Token = "0x6006CAC")]
    [Address(RVA = "0x46F5F44", Offset = "0x46F5F44", VA = "0x46F5F44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CAD")]
    [Address(RVA = "0x46F5FA4", Offset = "0x46F5FA4", VA = "0x46F5FA4", Slot = "5")]
    protected override AbilityBoardCustomPatternSettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardCustomPatternSettingData) null;
    }

    [Token(Token = "0x6006CAE")]
    [Address(RVA = "0x46F5FFC", Offset = "0x46F5FFC", VA = "0x46F5FFC")]
    public AbilityBoardCustomPatternSettingMaster()
    {
    }
  }
}
