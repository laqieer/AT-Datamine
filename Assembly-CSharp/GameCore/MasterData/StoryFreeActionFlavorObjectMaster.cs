// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionFlavorObjectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001256")]
  [Serializable]
  public sealed class StoryFreeActionFlavorObjectMaster : BaseMaster<StoryFreeActionFlavorObjectData>
  {
    [Token(Token = "0x40057C2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionFlavorObjectData>> dic;

    [Token(Token = "0x6006842")]
    [Address(RVA = "0x4D373A4", Offset = "0x4D373A4", VA = "0x4D373A4")]
    public IReadOnlyDictionary<int, StoryFreeActionFlavorObjectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionFlavorObjectData>) null;
    }

    [Token(Token = "0x6006843")]
    [Address(RVA = "0x4D373AC", Offset = "0x4D373AC", VA = "0x4D373AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006844")]
    [Address(RVA = "0x4D3746C", Offset = "0x4D3746C", VA = "0x4D3746C", Slot = "5")]
    protected override StoryFreeActionFlavorObjectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionFlavorObjectData) null;
    }

    [Token(Token = "0x6006845")]
    [Address(RVA = "0x4D37414", Offset = "0x4D37414", VA = "0x4D37414")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006846")]
    [Address(RVA = "0x4D374DC", Offset = "0x4D374DC", VA = "0x4D374DC")]
    private void OnLoadEntity(StoryFreeActionFlavorObjectData entity)
    {
    }

    [Token(Token = "0x6006847")]
    [Address(RVA = "0x4D3767C", Offset = "0x4D3767C", VA = "0x4D3767C")]
    public IReadOnlyList<StoryFreeActionFlavorObjectData> GetFlavorObjectDataList(int groupLabel)
    {
      return (IReadOnlyList<StoryFreeActionFlavorObjectData>) null;
    }

    [Token(Token = "0x6006848")]
    [Address(RVA = "0x4D37738", Offset = "0x4D37738", VA = "0x4D37738")]
    public IEnumerable<StoryFreeActionFlavorObjectData> GetList()
    {
      return (IEnumerable<StoryFreeActionFlavorObjectData>) null;
    }

    [Token(Token = "0x6006849")]
    [Address(RVA = "0x4D37788", Offset = "0x4D37788", VA = "0x4D37788")]
    public StoryFreeActionFlavorObjectMaster()
    {
    }
  }
}
