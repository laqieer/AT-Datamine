// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001326")]
  [Serializable]
  public sealed class AbilityBoardBoardListSettingMaster : 
    BaseMaster<AbilityBoardBoardListSettingData>
  {
    [Token(Token = "0x4005A72")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardBoardListSettingData>> descriptionTable;

    [Token(Token = "0x6006C16")]
    [Address(RVA = "0x48E8310", Offset = "0x48E8310", VA = "0x48E8310")]
    public IReadOnlyDictionary<int, AbilityBoardBoardListSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardBoardListSettingData>) null;
    }

    [Token(Token = "0x6006C17")]
    [Address(RVA = "0x48E8318", Offset = "0x48E8318", VA = "0x48E8318", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C18")]
    [Address(RVA = "0x48E85DC", Offset = "0x48E85DC", VA = "0x48E85DC", Slot = "5")]
    protected override AbilityBoardBoardListSettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardBoardListSettingData) null;
    }

    [Token(Token = "0x6006C19")]
    [Address(RVA = "0x48E864C", Offset = "0x48E864C", VA = "0x48E864C")]
    private void OnLoadEntity(AbilityBoardBoardListSettingData entity)
    {
    }

    [Token(Token = "0x6006C1A")]
    [Address(RVA = "0x48E8380", Offset = "0x48E8380", VA = "0x48E8380")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C1B")]
    [Address(RVA = "0x48E8650", Offset = "0x48E8650", VA = "0x48E8650")]
    private void GroupingByStyleExpId(AbilityBoardBoardListSettingData entity)
    {
    }

    [Token(Token = "0x6006C1C")]
    [Address(RVA = "0x48E880C", Offset = "0x48E880C", VA = "0x48E880C")]
    public IReadOnlyList<AbilityBoardBoardListSettingData> GetListByboradListId(int boradListId)
    {
      return (IReadOnlyList<AbilityBoardBoardListSettingData>) null;
    }

    [Token(Token = "0x6006C1D")]
    [Address(RVA = "0x48E88C8", Offset = "0x48E88C8", VA = "0x48E88C8")]
    public AbilityBoardBoardListSettingMaster()
    {
    }
  }
}
