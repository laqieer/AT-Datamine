// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryWeatherMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012FD")]
  [Serializable]
  public sealed class StoryWeatherMaster : BaseMaster<StoryWeatherData>
  {
    [Token(Token = "0x6006B57")]
    [Address(RVA = "0x48E1784", Offset = "0x48E1784", VA = "0x48E1784")]
    public IReadOnlyDictionary<int, StoryWeatherData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryWeatherData>) null;
    }

    [Token(Token = "0x6006B58")]
    [Address(RVA = "0x48E178C", Offset = "0x48E178C", VA = "0x48E178C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B59")]
    [Address(RVA = "0x48E17EC", Offset = "0x48E17EC", VA = "0x48E17EC", Slot = "5")]
    protected override StoryWeatherData LoadEntity(IMasterDataReader reader)
    {
      return (StoryWeatherData) null;
    }

    [Token(Token = "0x6006B5A")]
    [Address(RVA = "0x48E1844", Offset = "0x48E1844", VA = "0x48E1844")]
    public IEnumerable<StoryWeatherData> GetList() => (IEnumerable<StoryWeatherData>) null;

    [Token(Token = "0x6006B5B")]
    [Address(RVA = "0x48E1894", Offset = "0x48E1894", VA = "0x48E1894")]
    public StoryWeatherMaster()
    {
    }
  }
}
