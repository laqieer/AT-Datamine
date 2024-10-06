// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.MapListItemHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.MapList.UI;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapList
{
  [Token(Token = "0x2002E2F")]
  public class MapListItemHandler
  {
    [Token(Token = "0x400C641")]
    [FieldOffset(Offset = "0x10")]
    private MapListItemMainUI mainUI;
    [Token(Token = "0x400C642")]
    [FieldOffset(Offset = "0x18")]
    private MapListItemSubUI subUI;
    [Token(Token = "0x400C643")]
    [FieldOffset(Offset = "0x20")]
    private List<MapListItemSubUI> subUis;
    [Token(Token = "0x400C644")]
    [FieldOffset(Offset = "0x28")]
    private readonly InstanceHandler<MapListItemMainUI> mainUIInstanceHandler;
    [Token(Token = "0x400C645")]
    [FieldOffset(Offset = "0x30")]
    private readonly InstanceHandler<MapListItemSubUI> subUIInstanceHandler;
    [Token(Token = "0x400C646")]
    [FieldOffset(Offset = "0x38")]
    private bool expand;

    [Token(Token = "0x60120E1")]
    [Address(RVA = "0x437EB1C", Offset = "0x437EB1C", VA = "0x437EB1C")]
    public MapListItemHandler(MapListItemMainUI mainUI, MapListItemSubUI subUI)
    {
    }

    [Token(Token = "0x60120E2")]
    [Address(RVA = "0x437EC40", Offset = "0x437EC40", VA = "0x437EC40")]
    public MapListItemMainUI AppendMainUI(string title) => (MapListItemMainUI) null;

    [Token(Token = "0x60120E3")]
    [Address(RVA = "0x437ED10", Offset = "0x437ED10", VA = "0x437ED10")]
    private MapListItemMainUI GetMainUIInstance() => (MapListItemMainUI) null;

    [Token(Token = "0x60120E4")]
    [Address(RVA = "0x437EF38", Offset = "0x437EF38", VA = "0x437EF38")]
    public MapListItemSubUI AppendSubUI(string text, bool select, bool isPurpose)
    {
      return (MapListItemSubUI) null;
    }

    [Token(Token = "0x60120E5")]
    [Address(RVA = "0x437F04C", Offset = "0x437F04C", VA = "0x437F04C")]
    private MapListItemSubUI GetSubUIInstance() => (MapListItemSubUI) null;

    [Token(Token = "0x60120E6")]
    [Address(RVA = "0x437F228", Offset = "0x437F228", VA = "0x437F228")]
    public void Expand(bool expand)
    {
    }

    [Token(Token = "0x60120E7")]
    [Address(RVA = "0x437F3A4", Offset = "0x437F3A4", VA = "0x437F3A4")]
    private void Expand()
    {
    }

    [Token(Token = "0x60120E8")]
    [Address(RVA = "0x437F3B4", Offset = "0x437F3B4", VA = "0x437F3B4")]
    public void Release()
    {
    }

    [Token(Token = "0x60120E9")]
    [Address(RVA = "0x437F428", Offset = "0x437F428", VA = "0x437F428")]
    public void ChangeSelect(MapListItemSubUI selectSub)
    {
    }
  }
}
