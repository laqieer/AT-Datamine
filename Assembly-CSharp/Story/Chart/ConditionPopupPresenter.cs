// Decompiled with JetBrains decompiler
// Type: Story.Chart.ConditionPopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Story.Chart.UI;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006CB")]
  public static class ConditionPopupPresenter
  {
    [Token(Token = "0x6002674")]
    [Address(RVA = "0x2F4310C", Offset = "0x2F4310C", VA = "0x2F4310C")]
    public static bool IsBranch(Node node) => new bool();

    [Token(Token = "0x6002675")]
    [Address(RVA = "0x2F43280", Offset = "0x2F43280", VA = "0x2F43280")]
    public static bool IsTurningPoint(Node node) => new bool();

    [Token(Token = "0x6002676")]
    [Address(RVA = "0x2F434B4", Offset = "0x2F434B4", VA = "0x2F434B4")]
    public static void Show(
      AssetCachedSpawner spawner,
      Popup popup,
      StoryConditionPopupContent content,
      Node node)
    {
    }

    [Token(Token = "0x6002677")]
    [Address(RVA = "0x2F432B0", Offset = "0x2F432B0", VA = "0x2F432B0")]
    public static void Show(
      AssetCachedSpawner spawner,
      Popup popup,
      StoryTerningPointConditionPopupContent content,
      Node node)
    {
    }
  }
}
