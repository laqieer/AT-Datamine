// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001277")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectLayoutMaster : 
    BaseMaster<StoryFreeActionRewardObjectLayoutData>
  {
    [Token(Token = "0x400583C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, Dictionary<int, List<StoryFreeActionRewardObjectLayoutData>>> layoutDic;

    [Token(Token = "0x60068F8")]
    [Address(RVA = "0x48CB054", Offset = "0x48CB054", VA = "0x48CB054")]
    public IReadOnlyDictionary<int, StoryFreeActionRewardObjectLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionRewardObjectLayoutData>) null;
    }

    [Token(Token = "0x60068F9")]
    [Address(RVA = "0x48CB05C", Offset = "0x48CB05C", VA = "0x48CB05C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068FA")]
    [Address(RVA = "0x48CB114", Offset = "0x48CB114", VA = "0x48CB114", Slot = "5")]
    protected override StoryFreeActionRewardObjectLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionRewardObjectLayoutData) null;
    }

    [Token(Token = "0x60068FB")]
    [Address(RVA = "0x48CB0C4", Offset = "0x48CB0C4", VA = "0x48CB0C4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60068FC")]
    [Address(RVA = "0x48CB184", Offset = "0x48CB184", VA = "0x48CB184")]
    private void OnLoadEntity(StoryFreeActionRewardObjectLayoutData entity)
    {
    }

    [Token(Token = "0x60068FD")]
    [Address(RVA = "0x48CB3E0", Offset = "0x48CB3E0", VA = "0x48CB3E0")]
    public IReadOnlyList<StoryFreeActionRewardObjectLayoutData> GetLayoutGroupData(int layoutLabel)
    {
      return (IReadOnlyList<StoryFreeActionRewardObjectLayoutData>) null;
    }

    [Token(Token = "0x60068FE")]
    [Address(RVA = "0x48CB5CC", Offset = "0x48CB5CC", VA = "0x48CB5CC")]
    public IReadOnlyList<StoryFreeActionRewardObjectLayoutData> GetAreaLayoutData(
      int layoutLabel,
      int areaID)
    {
      return (IReadOnlyList<StoryFreeActionRewardObjectLayoutData>) null;
    }

    [Token(Token = "0x60068FF")]
    [Address(RVA = "0x48CB6C8", Offset = "0x48CB6C8", VA = "0x48CB6C8")]
    public IEnumerable<StoryFreeActionRewardObjectLayoutData> GetList()
    {
      return (IEnumerable<StoryFreeActionRewardObjectLayoutData>) null;
    }

    [Token(Token = "0x6006900")]
    [Address(RVA = "0x48CB718", Offset = "0x48CB718", VA = "0x48CB718")]
    public StoryFreeActionRewardObjectLayoutMaster()
    {
    }
  }
}
