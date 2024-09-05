// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestEventPageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001107")]
  [Serializable]
  public sealed class AreaQuestEventPageMaster : BaseMaster<AreaQuestEventPageData>
  {
    [Token(Token = "0x6006223")]
    [Address(RVA = "0x4ADCA50", Offset = "0x4ADCA50", VA = "0x4ADCA50")]
    public IReadOnlyDictionary<int, AreaQuestEventPageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestEventPageData>) null;
    }

    [Token(Token = "0x6006224")]
    [Address(RVA = "0x4ADCA58", Offset = "0x4ADCA58", VA = "0x4ADCA58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006225")]
    [Address(RVA = "0x4ADCAB8", Offset = "0x4ADCAB8", VA = "0x4ADCAB8", Slot = "5")]
    protected override AreaQuestEventPageData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestEventPageData) null;
    }

    [Token(Token = "0x6006226")]
    [Address(RVA = "0x4ADCB10", Offset = "0x4ADCB10", VA = "0x4ADCB10")]
    public bool CheckAreaEventQuestIsHeldNow(int areaQuestEventId) => new bool();

    [Token(Token = "0x6006227")]
    [Address(RVA = "0x4ADCC70", Offset = "0x4ADCC70", VA = "0x4ADCC70")]
    public AreaQuestEventPageData GetAreaQuestEventPageDataOne() => (AreaQuestEventPageData) null;

    [Token(Token = "0x6006228")]
    [Address(RVA = "0x4ADCE00", Offset = "0x4ADCE00", VA = "0x4ADCE00")]
    public AreaQuestEventPageMaster()
    {
    }
  }
}
