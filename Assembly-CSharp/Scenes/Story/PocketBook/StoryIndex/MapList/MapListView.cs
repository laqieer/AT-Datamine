// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.MapListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.MapList.UI;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapList
{
  [Token(Token = "0x2002E37")]
  public class MapListView
  {
    [Token(Token = "0x400C659")]
    [FieldOffset(Offset = "0x18")]
    private readonly List<MapListItemHandler> handlers;

    [Token(Token = "0x17003D7B")]
    public MapListUI MapListUI
    {
      [Token(Token = "0x601210C"), Address(RVA = "0x4381B44", Offset = "0x4381B44", VA = "0x4381B44")] private get
      {
        return (MapListUI) null;
      }
      [Token(Token = "0x601210D"), Address(RVA = "0x4381B4C", Offset = "0x4381B4C", VA = "0x4381B4C")] set
      {
      }
    }

    [Token(Token = "0x601210E")]
    [Address(RVA = "0x4381B54", Offset = "0x4381B54", VA = "0x4381B54")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601210F")]
    [Address(RVA = "0x4380D70", Offset = "0x4380D70", VA = "0x4380D70")]
    public MapListItemHandler GetHandler() => (MapListItemHandler) null;

    [Token(Token = "0x6012110")]
    [Address(RVA = "0x4381BC0", Offset = "0x4381BC0", VA = "0x4381BC0")]
    public void Show()
    {
    }

    [Token(Token = "0x6012111")]
    [Address(RVA = "0x4381BC4", Offset = "0x4381BC4", VA = "0x4381BC4")]
    public void Hide()
    {
    }

    [Token(Token = "0x6012112")]
    [Address(RVA = "0x4381BC8", Offset = "0x4381BC8", VA = "0x4381BC8")]
    public void Release()
    {
    }

    [Token(Token = "0x6012113")]
    [Address(RVA = "0x43819F4", Offset = "0x43819F4", VA = "0x43819F4")]
    public void ChangeSelect(MapListItemSubUI selectSub)
    {
    }

    [Token(Token = "0x6012114")]
    [Address(RVA = "0x4381D48", Offset = "0x4381D48", VA = "0x4381D48")]
    public MapListView()
    {
    }
  }
}
