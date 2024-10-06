// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001024")]
  [Serializable]
  public sealed class HomeEventMaster : BaseMaster<HomeEventData>
  {
    [Token(Token = "0x4005031")]
    public const string TEXT_AB = "text_masterdata_home";

    [Token(Token = "0x6005DED")]
    [Address(RVA = "0x2798444", Offset = "0x2798444", VA = "0x2798444")]
    public IReadOnlyDictionary<int, HomeEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, HomeEventData>) null;
    }

    [Token(Token = "0x6005DEE")]
    [Address(RVA = "0x279844C", Offset = "0x279844C", VA = "0x279844C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DEF")]
    [Address(RVA = "0x27984AC", Offset = "0x27984AC", VA = "0x27984AC", Slot = "5")]
    protected override HomeEventData LoadEntity(IMasterDataReader reader) => (HomeEventData) null;

    [Token(Token = "0x6005DF0")]
    [Address(RVA = "0x2798504", Offset = "0x2798504", VA = "0x2798504")]
    public HomeEventData GetHoldEvent() => (HomeEventData) null;

    [Token(Token = "0x6005DF1")]
    [Address(RVA = "0x2798738", Offset = "0x2798738", VA = "0x2798738")]
    public HomeEventMaster()
    {
    }
  }
}
