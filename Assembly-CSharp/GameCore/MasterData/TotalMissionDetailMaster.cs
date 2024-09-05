// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010AD")]
  [Serializable]
  public sealed class TotalMissionDetailMaster : BaseMaster<TotalMissionDetailData>
  {
    [Token(Token = "0x400521B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<TotalMissionDetailData>> descriptionTable;

    [Token(Token = "0x600607A")]
    [Address(RVA = "0x28D79E8", Offset = "0x28D79E8", VA = "0x28D79E8")]
    public IReadOnlyDictionary<int, TotalMissionDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TotalMissionDetailData>) null;
    }

    [Token(Token = "0x600607B")]
    [Address(RVA = "0x28D79F0", Offset = "0x28D79F0", VA = "0x28D79F0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600607C")]
    [Address(RVA = "0x28D7CB4", Offset = "0x28D7CB4", VA = "0x28D7CB4", Slot = "5")]
    protected override TotalMissionDetailData LoadEntity(IMasterDataReader reader)
    {
      return (TotalMissionDetailData) null;
    }

    [Token(Token = "0x600607D")]
    [Address(RVA = "0x28D7D24", Offset = "0x28D7D24", VA = "0x28D7D24")]
    private void OnLoadEntity(TotalMissionDetailData entity)
    {
    }

    [Token(Token = "0x600607E")]
    [Address(RVA = "0x28D7A58", Offset = "0x28D7A58", VA = "0x28D7A58")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x600607F")]
    [Address(RVA = "0x28D7D28", Offset = "0x28D7D28", VA = "0x28D7D28")]
    private void GroupingByTabId(TotalMissionDetailData entity)
    {
    }

    [Token(Token = "0x6006080")]
    [Address(RVA = "0x28D7EE4", Offset = "0x28D7EE4", VA = "0x28D7EE4")]
    public List<TotalMissionDetailData> GetListByTabId(int tabId)
    {
      return (List<TotalMissionDetailData>) null;
    }

    [Token(Token = "0x6006081")]
    [Address(RVA = "0x28D7FA0", Offset = "0x28D7FA0", VA = "0x28D7FA0")]
    public TotalMissionDetailMaster()
    {
    }
  }
}
