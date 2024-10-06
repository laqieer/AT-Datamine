// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.Map.UI.MapUIAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.Map.UI
{
  [Token(Token = "0x2002E0F")]
  public class MapUIAnimation
  {
    [Token(Token = "0x6011FED")]
    [Address(RVA = "0x437867C", Offset = "0x437867C", VA = "0x437867C")]
    public MapUIAnimation(MapUI mapUI)
    {
    }

    [Token(Token = "0x17003D53")]
    public UIAnimationController MapAnimationController
    {
      [Token(Token = "0x6011FEE"), Address(RVA = "0x437871C", Offset = "0x437871C", VA = "0x437871C")] get
      {
        return (UIAnimationController) null;
      }
    }

    [Token(Token = "0x6011FEF")]
    [Address(RVA = "0x4378724", Offset = "0x4378724", VA = "0x4378724")]
    public void PlayMapIn()
    {
    }

    [Token(Token = "0x6011FF0")]
    [Address(RVA = "0x437877C", Offset = "0x437877C", VA = "0x437877C")]
    public void PlayMapOut()
    {
    }

    [Token(Token = "0x2002E10")]
    public static class GroupID
    {
      [Token(Token = "0x400C5BE")]
      public const string MAP_IN = "Map_In";
      [Token(Token = "0x400C5BF")]
      public const string MAP_OUT = "Map_Out";
    }
  }
}
