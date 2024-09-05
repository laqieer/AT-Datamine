// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F3")]
  [Serializable]
  public sealed class AreaQuestAreaNodeQuestMaster : 
    BaseMaster<AreaQuestAreaNodeQuestData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x40052D0")]
    [FieldOffset(Offset = "0x18")]
    private readonly IReadOnlyList<AreaQuestAreaNodeQuestData> constEmptylist;
    [Token(Token = "0x40052D1")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<AreaQuestAreaNodeQuestData>> groupDict;

    [Token(Token = "0x60061B3")]
    [Address(RVA = "0x4AD7C2C", Offset = "0x4AD7C2C", VA = "0x4AD7C2C")]
    public IReadOnlyDictionary<int, AreaQuestAreaNodeQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaNodeQuestData>) null;
    }

    [Token(Token = "0x60061B4")]
    [Address(RVA = "0x4AD7C34", Offset = "0x4AD7C34", VA = "0x4AD7C34", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60061B5")]
    [Address(RVA = "0x4AD7CEC", Offset = "0x4AD7CEC", VA = "0x4AD7CEC", Slot = "5")]
    protected override AreaQuestAreaNodeQuestData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaNodeQuestData) null;
    }

    [Token(Token = "0x60061B6")]
    [Address(RVA = "0x4AD7C9C", Offset = "0x4AD7C9C", VA = "0x4AD7C9C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60061B7")]
    [Address(RVA = "0x4AD7D5C", Offset = "0x4AD7D5C", VA = "0x4AD7D5C")]
    private void OnLoadEntity(AreaQuestAreaNodeQuestData entity)
    {
    }

    [Token(Token = "0x60061B8")]
    [Address(RVA = "0x4AD7F34", Offset = "0x4AD7F34", VA = "0x4AD7F34")]
    public IReadOnlyList<AreaQuestAreaNodeQuestData> GetGroupList(int areaNodeQuestGroupId)
    {
      return (IReadOnlyList<AreaQuestAreaNodeQuestData>) null;
    }

    [Token(Token = "0x60061B9")]
    [Address(RVA = "0x4AD7FC8", Offset = "0x4AD7FC8", VA = "0x4AD7FC8")]
    public IReadOnlyCollection<AreaQuestAreaNodeQuestData> GetAllItem()
    {
      return (IReadOnlyCollection<AreaQuestAreaNodeQuestData>) null;
    }

    [Token(Token = "0x60061BA")]
    [Address(RVA = "0x4AD8018", Offset = "0x4AD8018", VA = "0x4AD8018", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x60061BB")]
    [Address(RVA = "0x4AD8070", Offset = "0x4AD8070", VA = "0x4AD8070")]
    public AreaQuestAreaNodeQuestMaster()
    {
    }
  }
}
