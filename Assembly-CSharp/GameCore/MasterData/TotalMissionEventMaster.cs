// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B0")]
  [Serializable]
  public sealed class TotalMissionEventMaster : BaseMaster<TotalMissionEventData>
  {
    [Token(Token = "0x6006089")]
    [Address(RVA = "0x28D8374", Offset = "0x28D8374", VA = "0x28D8374")]
    public IReadOnlyDictionary<int, TotalMissionEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TotalMissionEventData>) null;
    }

    [Token(Token = "0x600608A")]
    [Address(RVA = "0x28D837C", Offset = "0x28D837C", VA = "0x28D837C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600608B")]
    [Address(RVA = "0x28D83DC", Offset = "0x28D83DC", VA = "0x28D83DC", Slot = "5")]
    protected override TotalMissionEventData LoadEntity(IMasterDataReader reader)
    {
      return (TotalMissionEventData) null;
    }

    [Token(Token = "0x600608C")]
    [Address(RVA = "0x28D8434", Offset = "0x28D8434", VA = "0x28D8434")]
    public bool CheckTotalMissionIsHeld(int totalMissionEventId) => new bool();

    [Token(Token = "0x600608D")]
    [Address(RVA = "0x28D854C", Offset = "0x28D854C", VA = "0x28D854C")]
    public TotalMissionEventData GetAreaQuestEventPageData() => (TotalMissionEventData) null;

    [Token(Token = "0x600608E")]
    [Address(RVA = "0x28D8780", Offset = "0x28D8780", VA = "0x28D8780")]
    public TotalMissionEventMaster()
    {
    }
  }
}
