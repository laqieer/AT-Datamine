// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeEventBalloonMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001021")]
  [Serializable]
  public sealed class HomeEventBalloonMaster : BaseMaster<HomeEventBalloonData>
  {
    [Token(Token = "0x6005DDE")]
    [Address(RVA = "0x2797B3C", Offset = "0x2797B3C", VA = "0x2797B3C")]
    public IReadOnlyDictionary<int, HomeEventBalloonData> GetEntities()
    {
      return (IReadOnlyDictionary<int, HomeEventBalloonData>) null;
    }

    [Token(Token = "0x6005DDF")]
    [Address(RVA = "0x2797B44", Offset = "0x2797B44", VA = "0x2797B44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DE0")]
    [Address(RVA = "0x2797BA4", Offset = "0x2797BA4", VA = "0x2797BA4", Slot = "5")]
    protected override HomeEventBalloonData LoadEntity(IMasterDataReader reader)
    {
      return (HomeEventBalloonData) null;
    }

    [Token(Token = "0x6005DE1")]
    [Address(RVA = "0x2797BFC", Offset = "0x2797BFC", VA = "0x2797BFC")]
    public HomeEventBalloonData GetDisplayPeriodData() => (HomeEventBalloonData) null;

    [Token(Token = "0x6005DE2")]
    [Address(RVA = "0x2797EB8", Offset = "0x2797EB8", VA = "0x2797EB8")]
    public HomeEventBalloonMaster()
    {
    }
  }
}
