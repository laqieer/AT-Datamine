// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardStyleSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200135C")]
  [Serializable]
  public sealed class AbilityBoardStyleSettingMaster : BaseMaster<AbilityBoardStyleSettingData>
  {
    [Token(Token = "0x6006D10")]
    [Address(RVA = "0x46F965C", Offset = "0x46F965C", VA = "0x46F965C")]
    public IReadOnlyDictionary<int, AbilityBoardStyleSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardStyleSettingData>) null;
    }

    [Token(Token = "0x6006D11")]
    [Address(RVA = "0x46F9664", Offset = "0x46F9664", VA = "0x46F9664", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D12")]
    [Address(RVA = "0x46F96C4", Offset = "0x46F96C4", VA = "0x46F96C4", Slot = "5")]
    protected override AbilityBoardStyleSettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardStyleSettingData) null;
    }

    [Token(Token = "0x6006D13")]
    [Address(RVA = "0x46F971C", Offset = "0x46F971C", VA = "0x46F971C")]
    public AbilityBoardStyleSettingData GetDataByStyleId(int styleId)
    {
      return (AbilityBoardStyleSettingData) null;
    }

    [Token(Token = "0x6006D14")]
    [Address(RVA = "0x46F98A0", Offset = "0x46F98A0", VA = "0x46F98A0")]
    public AbilityBoardStyleSettingMaster()
    {
    }
  }
}
