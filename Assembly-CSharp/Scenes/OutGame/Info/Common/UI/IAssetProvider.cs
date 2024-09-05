// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.IAssetProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035D0")]
  public interface IAssetProvider
  {
    [Token(Token = "0x1700469F")]
    bool IsLoading { [Token(Token = "0x6015338")] get; }

    [Token(Token = "0x6015339")]
    void LoadRequest(string assetbundlelabel, string assetname, Action<UnityEngine.Object> onloaded);

    [Token(Token = "0x601533A")]
    void LoadRequest(string assetbundlelabel, string assetname, Action<Sprite> onloaded);

    [Token(Token = "0x601533B")]
    void LoadRequest(string assetbundlelabel, string assetname, Action<SpriteAtlas> onloaded);
  }
}
