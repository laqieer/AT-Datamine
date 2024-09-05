// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ChatInfo.ChatInfoLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.ChatInfo
{
  [Token(Token = "0x2003947")]
  public class ChatInfoLoader
  {
    [Token(Token = "0x400FA55")]
    private const string CHAT_STAMP_SPRITE_NAME = "Chat_Stamp_{0:D3}";
    [Token(Token = "0x400FA56")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, bool> isLoadedAssetBundleMap;

    [Token(Token = "0x601683B")]
    [Address(RVA = "0x42EB34C", Offset = "0x42EB34C", VA = "0x42EB34C")]
    private IEnumerator LoadDLCBySprite(
      string assetBundleLabel,
      string assetName,
      Action<Sprite> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601683C")]
    [Address(RVA = "0x42EB3FC", Offset = "0x42EB3FC", VA = "0x42EB3FC")]
    private void UnloadAssetBundle(string label, bool canUnloadAssetBundle)
    {
    }

    [Token(Token = "0x601683D")]
    [Address(RVA = "0x42EB4E4", Offset = "0x42EB4E4", VA = "0x42EB4E4")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601683E")]
    [Address(RVA = "0x42EB588", Offset = "0x42EB588", VA = "0x42EB588")]
    private bool CheckLoadedAssetBundle(string label) => new bool();

    [Token(Token = "0x601683F")]
    [Address(RVA = "0x42EB61C", Offset = "0x42EB61C", VA = "0x42EB61C")]
    public ChatInfoLoader()
    {
    }
  }
}
