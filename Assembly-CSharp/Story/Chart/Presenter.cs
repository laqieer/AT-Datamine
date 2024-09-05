// Decompiled with JetBrains decompiler
// Type: Story.Chart.Presenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Chart.UI;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006CA")]
  public static class Presenter
  {
    [Token(Token = "0x6002671")]
    [Address(RVA = "0x2F44AF8", Offset = "0x2F44AF8", VA = "0x2F44AF8")]
    public static bool IsNight(this StoryTimeSlotTypeEnum type) => new bool();

    [Token(Token = "0x6002672")]
    [Address(RVA = "0x2F42F0C", Offset = "0x2F42F0C", VA = "0x2F42F0C")]
    public static void Line(
      StoryChartNodeUI instance,
      Vector2 from,
      Vector2 to,
      bool locked,
      bool highlight,
      bool withEffect)
    {
    }

    [Token(Token = "0x6002673")]
    [Address(RVA = "0x2F42BB4", Offset = "0x2F42BB4", VA = "0x2F42BB4")]
    public static void Node(Story.Chart.Node node, StoryChartNodeUI instance)
    {
    }
  }
}
