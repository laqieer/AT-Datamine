// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeNormalDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F1")]
  [Serializable]
  public sealed class AreaQuestAreaNodeNormalDescriptionMaster : 
    BaseMaster<AreaQuestAreaNodeNormalDescriptionData>
  {
    [Token(Token = "0x40052CA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AreaQuestAreaNodeNormalDescriptionData>> descriptionTable;
    [Token(Token = "0x40052CB")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, AreaQuestAreaNodeNormalDescriptionData> dictByAreaNodeQuestGroupId;

    [Token(Token = "0x60061A3")]
    [Address(RVA = "0x28E2138", Offset = "0x28E2138", VA = "0x28E2138")]
    public IReadOnlyDictionary<int, AreaQuestAreaNodeNormalDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaNodeNormalDescriptionData>) null;
    }

    [Token(Token = "0x60061A4")]
    [Address(RVA = "0x28E2140", Offset = "0x28E2140", VA = "0x28E2140", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60061A5")]
    [Address(RVA = "0x28E221C", Offset = "0x28E221C", VA = "0x28E221C", Slot = "5")]
    protected override AreaQuestAreaNodeNormalDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaNodeNormalDescriptionData) null;
    }

    [Token(Token = "0x60061A6")]
    [Address(RVA = "0x28E21A8", Offset = "0x28E21A8", VA = "0x28E21A8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60061A7")]
    [Address(RVA = "0x28E228C", Offset = "0x28E228C", VA = "0x28E228C")]
    private void OnLoadEntity(AreaQuestAreaNodeNormalDescriptionData entity)
    {
    }

    [Token(Token = "0x60061A8")]
    [Address(RVA = "0x28E24F8", Offset = "0x28E24F8", VA = "0x28E24F8")]
    public AreaQuestAreaNodeNormalDescriptionData GetDataByAreaNodeQuestGroupId(
      int areaNodeQuestGroupId)
    {
      return (AreaQuestAreaNodeNormalDescriptionData) null;
    }

    [Token(Token = "0x60061A9")]
    [Address(RVA = "0x28E233C", Offset = "0x28E233C", VA = "0x28E233C")]
    private void GroupingByAreaNodeNormalId(AreaQuestAreaNodeNormalDescriptionData entity)
    {
    }

    [Token(Token = "0x60061AA")]
    [Address(RVA = "0x28E2570", Offset = "0x28E2570", VA = "0x28E2570")]
    public List<AreaQuestAreaNodeNormalDescriptionData> GetListByAreaNodeNormalId(
      int areaNodeNormalId)
    {
      return (List<AreaQuestAreaNodeNormalDescriptionData>) null;
    }

    [Token(Token = "0x60061AB")]
    [Address(RVA = "0x28E262C", Offset = "0x28E262C", VA = "0x28E262C")]
    public List<int> GetPreAdvList(int nodeTypeContensID) => (List<int>) null;

    [Token(Token = "0x60061AC")]
    [Address(RVA = "0x28E2A64", Offset = "0x28E2A64", VA = "0x28E2A64")]
    public List<int> GetAfterAdvList(int nodeTypeContensID) => (List<int>) null;

    [Token(Token = "0x60061AD")]
    [Address(RVA = "0x28E2EBC", Offset = "0x28E2EBC", VA = "0x28E2EBC")]
    public List<int> GetAdvList(int nodeTypeContensID) => (List<int>) null;

    [Token(Token = "0x60061AE")]
    [Address(RVA = "0x28E32E8", Offset = "0x28E32E8", VA = "0x28E32E8")]
    public AreaQuestAreaNodeNormalDescriptionMaster()
    {
    }
  }
}
