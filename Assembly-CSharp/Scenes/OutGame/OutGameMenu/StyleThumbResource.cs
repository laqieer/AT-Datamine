// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AE7")]
  public class StyleThumbResource
  {
    [Token(Token = "0x4010372")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4010373")]
    [FieldOffset(Offset = "0x18")]
    public Style styleData;
    [Token(Token = "0x4010374")]
    [FieldOffset(Offset = "0x20")]
    public bool IsNew;
    [Token(Token = "0x4010375")]
    [FieldOffset(Offset = "0x28")]
    public Action<StyleThumbResource> OnClickThumbnail;
    [Token(Token = "0x4010376")]
    [FieldOffset(Offset = "0x30")]
    public UnityEvent<bool> OnChangeNew;

    [Token(Token = "0x60172D7")]
    [Address(RVA = "0x300EF58", Offset = "0x300EF58", VA = "0x300EF58")]
    public StyleThumbResource()
    {
    }
  }
}
