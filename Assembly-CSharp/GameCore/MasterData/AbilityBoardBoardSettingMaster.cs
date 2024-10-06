// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200132B")]
  [Serializable]
  public sealed class AbilityBoardBoardSettingMaster : BaseMaster<AbilityBoardBoardSettingData>
  {
    [Token(Token = "0x4005A7F")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardBoardSettingData>> descriptionTable;

    [Token(Token = "0x6006C2D")]
    [Address(RVA = "0x46F0FD4", Offset = "0x46F0FD4", VA = "0x46F0FD4")]
    public IReadOnlyDictionary<int, AbilityBoardBoardSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardBoardSettingData>) null;
    }

    [Token(Token = "0x6006C2E")]
    [Address(RVA = "0x46F0FDC", Offset = "0x46F0FDC", VA = "0x46F0FDC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C2F")]
    [Address(RVA = "0x46F12A0", Offset = "0x46F12A0", VA = "0x46F12A0", Slot = "5")]
    protected override AbilityBoardBoardSettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardBoardSettingData) null;
    }

    [Token(Token = "0x6006C30")]
    [Address(RVA = "0x46F1310", Offset = "0x46F1310", VA = "0x46F1310")]
    private void OnLoadEntity(AbilityBoardBoardSettingData entity)
    {
    }

    [Token(Token = "0x6006C31")]
    [Address(RVA = "0x46F1044", Offset = "0x46F1044", VA = "0x46F1044")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C32")]
    [Address(RVA = "0x46F1314", Offset = "0x46F1314", VA = "0x46F1314")]
    private void GroupingByStyleExpId(AbilityBoardBoardSettingData entity)
    {
    }

    [Token(Token = "0x6006C33")]
    [Address(RVA = "0x46F14D0", Offset = "0x46F14D0", VA = "0x46F14D0")]
    public IReadOnlyList<AbilityBoardBoardSettingData> GetListByboardId(int boardId)
    {
      return (IReadOnlyList<AbilityBoardBoardSettingData>) null;
    }

    [Token(Token = "0x6006C34")]
    [Address(RVA = "0x46F158C", Offset = "0x46F158C", VA = "0x46F158C")]
    public AbilityBoardBoardSettingData GetDataByboardIdAndNodeId(int boardId, int nodeId)
    {
      return (AbilityBoardBoardSettingData) null;
    }

    [Token(Token = "0x6006C35")]
    [Address(RVA = "0x46F1730", Offset = "0x46F1730", VA = "0x46F1730")]
    public AbilityBoardBoardSettingMaster()
    {
    }
  }
}
