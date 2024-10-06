// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.MapWorldLocationDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.QuestSelectMap;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033D2")]
  public class MapWorldLocationDataProvider : ILocationDataProvider
  {
    [Token(Token = "0x400E12E")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, ILocationDataProvider.LocationData> dict;

    [Token(Token = "0x60145E4")]
    [Address(RVA = "0x1886210", Offset = "0x1886210", VA = "0x1886210")]
    public MapWorldLocationDataProvider(
      Dictionary<int, ILocationDataProvider.LocationData> dict)
    {
    }

    [Token(Token = "0x60145E5")]
    [Address(RVA = "0x1887038", Offset = "0x1887038", VA = "0x1887038", Slot = "4")]
    private ILocationDataProvider.LocationData? Scenes\u002EOutGame\u002EQuestSelectMap\u002EILocationDataProvider\u002EGetLocationData(
      int locationHandleId)
    {
      return new ILocationDataProvider.LocationData?();
    }
  }
}
