// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.FavoriteSelect.IStyleInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.Utility;
using StaqData;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.FavoriteSelect
{
  [Token(Token = "0x20034CB")]
  public interface IStyleInventory
  {
    [Token(Token = "0x170044B0")]
    float ListItemWidth { [Token(Token = "0x6014B74")] get; }

    [Token(Token = "0x170044B1")]
    int ThumbSelectedIndex { [Token(Token = "0x6014B75")] get; }

    [Token(Token = "0x170044B2")]
    int BaseEntryMax { [Token(Token = "0x6014B76")] get; }

    [Token(Token = "0x170044B3")]
    NewBadgeProxy NewBadgeProxy { [Token(Token = "0x6014B77")] get; }

    [Token(Token = "0x6014B78")]
    void AddStyleThumb(StyleThumb styleThumb);

    [Token(Token = "0x6014B79")]
    void RemoveStyleThumb(StyleThumb styleThumb);

    [Token(Token = "0x6014B7A")]
    Style[] GetThumbStyleList(int index);

    [Token(Token = "0x6014B7B")]
    void AddLoadAssetBundle(string name);

    [Token(Token = "0x6014B7C")]
    void ThumbOnClick(int index);

    [Token(Token = "0x170044B4")]
    AssetCachedSpawner AssetSpawner { [Token(Token = "0x6014B7D")] get; }
  }
}
