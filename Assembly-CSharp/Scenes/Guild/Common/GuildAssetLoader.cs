// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Common.GuildAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Common
{
  [Token(Token = "0x2002C25")]
  public class GuildAssetLoader
  {
    [Token(Token = "0x400BC0F")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineUpdater;
    [Token(Token = "0x400BC10")]
    [FieldOffset(Offset = "0x18")]
    private HashSet<string> loadedAssetBundleNames;
    [Token(Token = "0x400BC11")]
    [FieldOffset(Offset = "0x20")]
    private HashSet<string> loadrequestAssetBundleNames;

    [Token(Token = "0x60114C9")]
    [Address(RVA = "0x4A1BD14", Offset = "0x4A1BD14", VA = "0x4A1BD14")]
    public GuildAssetLoader(MonoBehaviour coroutineUpdater)
    {
    }

    [Token(Token = "0x60114CA")]
    [Address(RVA = "0x4A1BD3C", Offset = "0x4A1BD3C", VA = "0x4A1BD3C")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x60114CB")]
    private IEnumerator LoadAsset<T>(
      string assetBundleName,
      string assetName,
      Action<T> onLoadComplete)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60114CC")]
    public void LoadAssetAsync<T>(
      string assetBundleName,
      string assetName,
      Action<T> onLoadComplete)
      where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x60114CD")]
    private IEnumerator LoadPrefab<T>(
      string assetBundleName,
      string prefabName,
      Action<T> onLoadComplete)
      where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60114CE")]
    public void LoadPrefabAsync<T>(
      string assetBundleName,
      string prefabName,
      Action<T> onLoadComplete)
      where T : MonoBehaviour
    {
    }

    [Token(Token = "0x60114CF")]
    [Address(RVA = "0x4A1BD58", Offset = "0x4A1BD58", VA = "0x4A1BD58")]
    public void RequestLoadAssetBundle(string assetBundleName)
    {
    }

    [Token(Token = "0x60114D0")]
    [Address(RVA = "0x4A1BF28", Offset = "0x4A1BF28", VA = "0x4A1BF28")]
    public void RequestLoadAssetBundle(IEnumerable<string> assetBundleNames)
    {
    }

    [Token(Token = "0x60114D1")]
    [Address(RVA = "0x4A1C200", Offset = "0x4A1C200", VA = "0x4A1C200")]
    public IEnumerator LoadRequestedAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x60114D2")]
    [Address(RVA = "0x4A1C290", Offset = "0x4A1C290", VA = "0x4A1C290")]
    private void OnLoadAssetBundles(List<string> successList, Dictionary<string, string> errorDic)
    {
    }

    [Token(Token = "0x60114D3")]
    [Address(RVA = "0x4A1C42C", Offset = "0x4A1C42C", VA = "0x4A1C42C")]
    private void RegisterLoadedAssetBundleName(string assetBundleName)
    {
    }

    [Token(Token = "0x60114D4")]
    [Address(RVA = "0x4A1BEC8", Offset = "0x4A1BEC8", VA = "0x4A1BEC8")]
    public bool IsLoadedAssetBundle(string assetBundleName) => new bool();

    [Token(Token = "0x60114D5")]
    [Address(RVA = "0x4A1C504", Offset = "0x4A1C504", VA = "0x4A1C504")]
    public void UnloadAssetBundles()
    {
    }

    [Token(Token = "0x2002C26")]
    public class AssetLoadOperation<T> : IEnumerator<T>, IEnumerator, IDisposable where T : UnityEngine.Object
    {
      [Token(Token = "0x400BC13")]
      [FieldOffset(Offset = "0x0")]
      private IEnumerator enumerator;

      [Token(Token = "0x17003BBF")]
      public T Current
      {
        [Token(Token = "0x60114D6")] get => (T) null;
      }

      [Token(Token = "0x17003BC0")]
      private object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [Token(Token = "0x60114D7")] get => (object) null;
      }

      [Token(Token = "0x60114D8")]
      public bool MoveNext() => new bool();

      [Token(Token = "0x60114D9")]
      public void Reset()
      {
      }

      [Token(Token = "0x60114DA")]
      public void Dispose()
      {
      }

      [Token(Token = "0x17003BC1")]
      public T Asset
      {
        [Token(Token = "0x60114DB")] get => (T) null;
        [Token(Token = "0x60114DC")] private set
        {
        }
      }

      [Token(Token = "0x17003BC2")]
      public bool IsDone
      {
        [Token(Token = "0x60114DD")] get => new bool();
        [Token(Token = "0x60114DE")] private set
        {
        }
      }

      [Token(Token = "0x17003BC3")]
      public bool IsError
      {
        [Token(Token = "0x60114DF")] get => new bool();
        [Token(Token = "0x60114E0")] private set
        {
        }
      }

      [Token(Token = "0x17003BC4")]
      public string ErrorMessage
      {
        [Token(Token = "0x60114E1")] get => (string) null;
        [Token(Token = "0x60114E2")] private set
        {
        }
      }

      [Token(Token = "0x60114E3")]
      private AssetLoadOperation()
      {
      }

      [Token(Token = "0x60114E4")]
      public static GuildAssetLoader.AssetLoadOperation<T> StartLoad(
        string assetBundleName,
        string assetName)
      {
        return (GuildAssetLoader.AssetLoadOperation<T>) null;
      }

      [Token(Token = "0x60114E5")]
      private IEnumerator StartLoadRoutine(string assetBundleName, string assetName)
      {
        return (IEnumerator) null;
      }
    }
  }
}
