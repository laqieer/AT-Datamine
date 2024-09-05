// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.AssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035D1")]
  public class AssetLoader : ICoroutineTask, IAssetProvider
  {
    [Token(Token = "0x400EA4B")]
    [FieldOffset(Offset = "0x10")]
    private Queue<AssetLoader.Request> queue;
    [Token(Token = "0x400EA4C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, string> loadedAssetBundleLabels;
    [Token(Token = "0x400EA4D")]
    [FieldOffset(Offset = "0x20")]
    private AssetBundleManager assetbundleManager;

    [Token(Token = "0x170046A0")]
    public bool Queueing
    {
      [Token(Token = "0x601533C"), Address(RVA = "0x4D8A3DC", Offset = "0x4D8A3DC", VA = "0x4D8A3DC", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601533D")]
    [Address(RVA = "0x4D8A42C", Offset = "0x4D8A42C", VA = "0x4D8A42C", Slot = "5")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x601533E")]
    [Address(RVA = "0x4D8A4BC", Offset = "0x4D8A4BC", VA = "0x4D8A4BC", Slot = "6")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x170046A1")]
    public bool IsLoading
    {
      [Token(Token = "0x601533F"), Address(RVA = "0x4D8A65C", Offset = "0x4D8A65C", VA = "0x4D8A65C", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015340")]
    [Address(RVA = "0x4D8A664", Offset = "0x4D8A664", VA = "0x4D8A664", Slot = "8")]
    private void Scenes\u002EOutGame\u002EInfo\u002ECommon\u002EUI\u002EIAssetProvider\u002ELoadRequest(
      string assetbundlelabel,
      string assetname,
      Action<UnityEngine.Object> onloaded)
    {
    }

    [Token(Token = "0x6015341")]
    [Address(RVA = "0x4D8A714", Offset = "0x4D8A714", VA = "0x4D8A714", Slot = "9")]
    private void Scenes\u002EOutGame\u002EInfo\u002ECommon\u002EUI\u002EIAssetProvider\u002ELoadRequest(
      string assetbundlelabel,
      string assetname,
      Action<Sprite> onloaded)
    {
    }

    [Token(Token = "0x6015342")]
    [Address(RVA = "0x4D8A83C", Offset = "0x4D8A83C", VA = "0x4D8A83C", Slot = "10")]
    private void Scenes\u002EOutGame\u002EInfo\u002ECommon\u002EUI\u002EIAssetProvider\u002ELoadRequest(
      string assetbundlelabel,
      string assetname,
      Action<SpriteAtlas> onloaded)
    {
    }

    [Token(Token = "0x6015343")]
    [Address(RVA = "0x4D8A964", Offset = "0x4D8A964", VA = "0x4D8A964")]
    public AssetLoader()
    {
    }

    [Token(Token = "0x20035D2")]
    private class Request
    {
      [Token(Token = "0x170046A2")]
      public string AssetBundleLabel
      {
        [Token(Token = "0x6015346"), Address(RVA = "0x4D8ABA8", Offset = "0x4D8ABA8", VA = "0x4D8ABA8")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6015347"), Address(RVA = "0x4D8ABB0", Offset = "0x4D8ABB0", VA = "0x4D8ABB0")] set
        {
        }
      }

      [Token(Token = "0x170046A3")]
      public string AssetName
      {
        [Token(Token = "0x6015348"), Address(RVA = "0x4D8ABB8", Offset = "0x4D8ABB8", VA = "0x4D8ABB8")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6015349"), Address(RVA = "0x4D8ABC0", Offset = "0x4D8ABC0", VA = "0x4D8ABC0")] set
        {
        }
      }

      [Token(Token = "0x170046A4")]
      public Action<UnityEngine.Object> Onloaded
      {
        [Token(Token = "0x601534A"), Address(RVA = "0x4D8ABC8", Offset = "0x4D8ABC8", VA = "0x4D8ABC8")] get
        {
          return (Action<UnityEngine.Object>) null;
        }
        [Token(Token = "0x601534B"), Address(RVA = "0x4D8ABD0", Offset = "0x4D8ABD0", VA = "0x4D8ABD0")] set
        {
        }
      }

      [Token(Token = "0x601534C")]
      [Address(RVA = "0x4D8A70C", Offset = "0x4D8A70C", VA = "0x4D8A70C")]
      public Request()
      {
      }
    }
  }
}
