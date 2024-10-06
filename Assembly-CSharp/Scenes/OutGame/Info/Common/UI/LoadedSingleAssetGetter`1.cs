// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.LoadedSingleAssetGetter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035D9")]
  public class LoadedSingleAssetGetter<T> where T : Component
  {
    [Token(Token = "0x170046AA")]
    public string AssetbundleName
    {
      [Token(Token = "0x6015367")] get => (string) null;
    }

    [Token(Token = "0x170046AB")]
    public string AssetName
    {
      [Token(Token = "0x6015368")] get => (string) null;
    }

    [Token(Token = "0x6015369")]
    public LoadedSingleAssetGetter(string assetbundleName, string assetName)
    {
    }

    [Token(Token = "0x601536A")]
    public T Instantiate(Transform parent = null, Action<T> initialize = null) => (T) null;
  }
}
