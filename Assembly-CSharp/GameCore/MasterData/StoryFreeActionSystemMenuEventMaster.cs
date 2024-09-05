// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSystemMenuEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001281")]
  [Serializable]
  public sealed class StoryFreeActionSystemMenuEventMaster : 
    BaseMaster<StoryFreeActionSystemMenuEventData>
  {
    [Token(Token = "0x400586E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionSystemMenuEventData>> groupingTable;

    [Token(Token = "0x600692D")]
    [Address(RVA = "0x48CD794", Offset = "0x48CD794", VA = "0x48CD794")]
    public IReadOnlyDictionary<int, StoryFreeActionSystemMenuEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionSystemMenuEventData>) null;
    }

    [Token(Token = "0x600692E")]
    [Address(RVA = "0x48CD79C", Offset = "0x48CD79C", VA = "0x48CD79C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600692F")]
    [Address(RVA = "0x48CD860", Offset = "0x48CD860", VA = "0x48CD860", Slot = "5")]
    protected override StoryFreeActionSystemMenuEventData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionSystemMenuEventData) null;
    }

    [Token(Token = "0x6006930")]
    [Address(RVA = "0x48CD804", Offset = "0x48CD804", VA = "0x48CD804")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006931")]
    [Address(RVA = "0x48CD8D0", Offset = "0x48CD8D0", VA = "0x48CD8D0")]
    private void OnLoadEntity(StoryFreeActionSystemMenuEventData entity)
    {
    }

    [Token(Token = "0x6006932")]
    [Address(RVA = "0x48CDA4C", Offset = "0x48CDA4C", VA = "0x48CDA4C")]
    public IReadOnlyList<StoryFreeActionSystemMenuEventData> GetGroupListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionSystemMenuEventData>) null;
    }

    [Token(Token = "0x6006933")]
    [Address(RVA = "0x48CDB08", Offset = "0x48CDB08", VA = "0x48CDB08")]
    public IEnumerable<StoryFreeActionSystemMenuEventData> GetList()
    {
      return (IEnumerable<StoryFreeActionSystemMenuEventData>) null;
    }

    [Token(Token = "0x6006934")]
    [Address(RVA = "0x48CDB58", Offset = "0x48CDB58", VA = "0x48CDB58")]
    public StoryFreeActionSystemMenuEventMaster()
    {
    }
  }
}
