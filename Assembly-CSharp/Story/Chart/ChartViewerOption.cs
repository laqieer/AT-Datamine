// Decompiled with JetBrains decompiler
// Type: Story.Chart.ChartViewerOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006E4")]
  public static class ChartViewerOption
  {
    [Token(Token = "0x600271E")]
    [Address(RVA = "0x366C234", Offset = "0x366C234", VA = "0x366C234")]
    public static INodeStatus Create(this ChartViewerOption.ViewType viewtype, StoryID storyID)
    {
      return (INodeStatus) null;
    }

    [Token(Token = "0x20006E5")]
    public enum ViewType
    {
      [Token(Token = "0x400208A")] CurrentLoop,
      [Token(Token = "0x400208B")] AllLoop,
      [Token(Token = "0x400208C")] All,
    }
  }
}
