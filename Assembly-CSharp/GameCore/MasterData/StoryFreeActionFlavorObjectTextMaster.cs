// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionFlavorObjectTextMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001258")]
  [Serializable]
  public sealed class StoryFreeActionFlavorObjectTextMaster : 
    BaseMaster<StoryFreeActionFlavorObjectTextData>
  {
    [Token(Token = "0x40057CD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionFlavorObjectTextData>> groupingDic;

    [Token(Token = "0x6006851")]
    [Address(RVA = "0x4D37CE0", Offset = "0x4D37CE0", VA = "0x4D37CE0")]
    public IReadOnlyDictionary<int, StoryFreeActionFlavorObjectTextData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionFlavorObjectTextData>) null;
    }

    [Token(Token = "0x6006852")]
    [Address(RVA = "0x4D37CE8", Offset = "0x4D37CE8", VA = "0x4D37CE8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006853")]
    [Address(RVA = "0x4D38000", Offset = "0x4D38000", VA = "0x4D38000", Slot = "5")]
    protected override StoryFreeActionFlavorObjectTextData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionFlavorObjectTextData) null;
    }

    [Token(Token = "0x6006854")]
    [Address(RVA = "0x4D37D58", Offset = "0x4D37D58", VA = "0x4D37D58")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006855")]
    [Address(RVA = "0x4D38070", Offset = "0x4D38070", VA = "0x4D38070")]
    private void OnLoadEntity(StoryFreeActionFlavorObjectTextData entity)
    {
    }

    [Token(Token = "0x6006856")]
    [Address(RVA = "0x4D37DB0", Offset = "0x4D37DB0", VA = "0x4D37DB0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006857")]
    [Address(RVA = "0x4D381EC", Offset = "0x4D381EC", VA = "0x4D381EC")]
    public IReadOnlyList<StoryFreeActionFlavorObjectTextData> GetGroupingList(int tableID)
    {
      return (IReadOnlyList<StoryFreeActionFlavorObjectTextData>) null;
    }

    [Token(Token = "0x6006858")]
    [Address(RVA = "0x4D382A8", Offset = "0x4D382A8", VA = "0x4D382A8")]
    public IEnumerable<StoryFreeActionFlavorObjectTextData> GetList()
    {
      return (IEnumerable<StoryFreeActionFlavorObjectTextData>) null;
    }

    [Token(Token = "0x6006859")]
    [Address(RVA = "0x4D382F8", Offset = "0x4D382F8", VA = "0x4D382F8")]
    public StoryFreeActionFlavorObjectTextMaster()
    {
    }
  }
}
