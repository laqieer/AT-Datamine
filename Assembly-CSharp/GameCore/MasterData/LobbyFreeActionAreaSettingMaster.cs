// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionAreaSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001075")]
  [Serializable]
  public sealed class LobbyFreeActionAreaSettingMaster : BaseMaster<LobbyFreeActionAreaSettingData>
  {
    [Token(Token = "0x4005161")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<LobbyFreeActionAreaSettingData>> groupingTable;

    [Token(Token = "0x6005F63")]
    [Address(RVA = "0x28CD930", Offset = "0x28CD930", VA = "0x28CD930")]
    public IReadOnlyDictionary<int, LobbyFreeActionAreaSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6005F64")]
    [Address(RVA = "0x28CD938", Offset = "0x28CD938", VA = "0x28CD938", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F65")]
    [Address(RVA = "0x28CD9FC", Offset = "0x28CD9FC", VA = "0x28CD9FC", Slot = "5")]
    protected override LobbyFreeActionAreaSettingData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6005F66")]
    [Address(RVA = "0x28CD9A0", Offset = "0x28CD9A0", VA = "0x28CD9A0")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005F67")]
    [Address(RVA = "0x28CDA6C", Offset = "0x28CDA6C", VA = "0x28CDA6C")]
    private void OnLoadEntity(LobbyFreeActionAreaSettingData entity)
    {
    }

    [Token(Token = "0x6005F68")]
    [Address(RVA = "0x28CDBE8", Offset = "0x28CDBE8", VA = "0x28CDBE8")]
    public IReadOnlyList<LobbyFreeActionAreaSettingData> GetAreaSettingDataListByLabel(int label)
    {
      return (IReadOnlyList<LobbyFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6005F69")]
    [Address(RVA = "0x28CDCA4", Offset = "0x28CDCA4", VA = "0x28CDCA4")]
    public LobbyFreeActionAreaSettingData GetAreaSetting(
      int label,
      int chapterID,
      DateTime currentTime)
    {
      return (LobbyFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6005F6A")]
    [Address(RVA = "0x28CE0F0", Offset = "0x28CE0F0", VA = "0x28CE0F0")]
    public IReadOnlyCollection<LobbyFreeActionAreaSettingData> GetList()
    {
      return (IReadOnlyCollection<LobbyFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6005F6B")]
    [Address(RVA = "0x28CE140", Offset = "0x28CE140", VA = "0x28CE140")]
    public LobbyFreeActionAreaSettingMaster()
    {
    }
  }
}
