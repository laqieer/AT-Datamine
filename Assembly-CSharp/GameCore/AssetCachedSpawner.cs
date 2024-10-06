// Decompiled with JetBrains decompiler
// Type: GameCore.AssetCachedSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BBD")]
  public class AssetCachedSpawner : MonoBehaviour
  {
    [Token(Token = "0x400358A")]
    [FieldOffset(Offset = "0x0")]
    private static List<AssetCachedSpawner> spawners;
    [Token(Token = "0x400358B")]
    [FieldOffset(Offset = "0x18")]
    private List<AssetCachedSpawner.CacheParameter> caches;
    [Token(Token = "0x400358C")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, UnityEngine.Object> preloadCaches;
    [Token(Token = "0x400358D")]
    [FieldOffset(Offset = "0x28")]
    private List<AssetCachedSpawner.LoadRequest> requestList;
    [Token(Token = "0x400358E")]
    [FieldOffset(Offset = "0x30")]
    private List<AssetCachedSpawner.LoadRequest> loadingRequestList;
    [Token(Token = "0x400358F")]
    [FieldOffset(Offset = "0x38")]
    private AssetBundleManager assetBundleManager;
    [Token(Token = "0x4003590")]
    [FieldOffset(Offset = "0x40")]
    private StringBuilder requetKeyBuilder;
    [Token(Token = "0x4003591")]
    [FieldOffset(Offset = "0x48")]
    private AssetLoadBalancer balancer;
    [Token(Token = "0x4003592")]
    [FieldOffset(Offset = "0x50")]
    private int requestLoadingMax;
    [Token(Token = "0x4003593")]
    [FieldOffset(Offset = "0x54")]
    private int cacheMax;

    [Token(Token = "0x170009B4")]
    private bool IsLoading
    {
      [Token(Token = "0x600430F"), Address(RVA = "0x363E200", Offset = "0x363E200", VA = "0x363E200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004310")]
    [Address(RVA = "0x363E26C", Offset = "0x363E26C", VA = "0x363E26C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004311")]
    [Address(RVA = "0x363E424", Offset = "0x363E424", VA = "0x363E424")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004312")]
    [Address(RVA = "0x363BF88", Offset = "0x363BF88", VA = "0x363BF88")]
    public void SetAssetCacheMax(int max)
    {
    }

    [Token(Token = "0x6004313")]
    [Address(RVA = "0x363E4AC", Offset = "0x363E4AC", VA = "0x363E4AC")]
    public void StartRequest()
    {
    }

    [Token(Token = "0x6004314")]
    [Address(RVA = "0x363E87C", Offset = "0x363E87C", VA = "0x363E87C")]
    public void CancelRequest(AssetSpawnOperationBase op)
    {
    }

    [Token(Token = "0x6004315")]
    [Address(RVA = "0x363C1EC", Offset = "0x363C1EC", VA = "0x363C1EC")]
    public bool WaitLoading() => new bool();

    [Token(Token = "0x6004316")]
    [Address(RVA = "0x363C06C", Offset = "0x363C06C", VA = "0x363C06C")]
    public void ClearCacheAll()
    {
    }

    [Token(Token = "0x6004317")]
    [Address(RVA = "0x363ECB8", Offset = "0x363ECB8", VA = "0x363ECB8")]
    public void ClearCache(string assetBundleName, string assetName)
    {
    }

    [Token(Token = "0x6004318")]
    public void Preload<T>(string assetBundleName, string assetName) where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x6004319")]
    public AssetSpawnOperation<T> SpawnAsync<T>(
      string assetBundleName,
      string assetName,
      Action<T> onFinish = null)
      where T : UnityEngine.Object
    {
      return (AssetSpawnOperation<T>) null;
    }

    [Token(Token = "0x600431A")]
    [Address(RVA = "0x363E814", Offset = "0x363E814", VA = "0x363E814")]
    private IEnumerator RequestProcessingAsync() => (IEnumerator) null;

    [Token(Token = "0x600431B")]
    private IEnumerator LoadAssetAsync<T>(AssetCachedSpawner.LoadRequest request) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600431C")]
    private void SpawnResult<T>(AssetCachedSpawner.LoadRequest request, UnityEngine.Object asset) where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x600431D")]
    [Address(RVA = "0x363EE44", Offset = "0x363EE44", VA = "0x363EE44")]
    private string CreateKey(string assetBundleName, string assetName) => (string) null;

    [Token(Token = "0x600431E")]
    [Address(RVA = "0x363EED8", Offset = "0x363EED8", VA = "0x363EED8")]
    private void StoreCache(string key, UnityEngine.Object asset, bool isPreload)
    {
    }

    [Token(Token = "0x600431F")]
    [Address(RVA = "0x363F058", Offset = "0x363F058", VA = "0x363F058")]
    private bool TryGetCache(string key, out UnityEngine.Object asset, bool isPreload)
    {
      return new bool();
    }

    [Token(Token = "0x6004320")]
    [Address(RVA = "0x363E520", Offset = "0x363E520", VA = "0x363E520")]
    private void ClearOldCache()
    {
    }

    [Token(Token = "0x6004321")]
    [Address(RVA = "0x363F5C4", Offset = "0x363F5C4", VA = "0x363F5C4")]
    private bool IsLoadingShouldWait() => new bool();

    [Token(Token = "0x6004322")]
    [Address(RVA = "0x363F780", Offset = "0x363F780", VA = "0x363F780")]
    public AssetCachedSpawner()
    {
    }

    [Token(Token = "0x6004323")]
    [Address(RVA = "0x363F910", Offset = "0x363F910", VA = "0x363F910")]
    static AssetCachedSpawner()
    {
    }

    [Token(Token = "0x2000BBE")]
    private class LoadRequest
    {
      [Token(Token = "0x400359A")]
      [FieldOffset(Offset = "0x30")]
      public UnityEngine.Object LoadedAsset;
      [Token(Token = "0x400359B")]
      [FieldOffset(Offset = "0x38")]
      public List<AssetSpawnOperationBase> ResultList;

      [Token(Token = "0x170009B5")]
      public string Key
      {
        [Token(Token = "0x6004324"), Address(RVA = "0x363F99C", Offset = "0x363F99C", VA = "0x363F99C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004325"), Address(RVA = "0x363F9A4", Offset = "0x363F9A4", VA = "0x363F9A4")] private set
        {
        }
      }

      [Token(Token = "0x170009B6")]
      public string AssetBundleName
      {
        [Token(Token = "0x6004326"), Address(RVA = "0x363F9AC", Offset = "0x363F9AC", VA = "0x363F9AC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004327"), Address(RVA = "0x363F9B4", Offset = "0x363F9B4", VA = "0x363F9B4")] private set
        {
        }
      }

      [Token(Token = "0x170009B7")]
      public string AssetName
      {
        [Token(Token = "0x6004328"), Address(RVA = "0x363F9BC", Offset = "0x363F9BC", VA = "0x363F9BC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004329"), Address(RVA = "0x363F9C4", Offset = "0x363F9C4", VA = "0x363F9C4")] private set
        {
        }
      }

      [Token(Token = "0x170009B8")]
      public bool IsPreload
      {
        [Token(Token = "0x600432A"), Address(RVA = "0x363F9CC", Offset = "0x363F9CC", VA = "0x363F9CC")] get
        {
          return new bool();
        }
        [Token(Token = "0x600432B"), Address(RVA = "0x363F9D4", Offset = "0x363F9D4", VA = "0x363F9D4")] private set
        {
        }
      }

      [Token(Token = "0x170009B9")]
      public bool IsCancel
      {
        [Token(Token = "0x600432C"), Address(RVA = "0x363F9E0", Offset = "0x363F9E0", VA = "0x363F9E0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600432D"), Address(RVA = "0x363F9E8", Offset = "0x363F9E8", VA = "0x363F9E8")] set
        {
        }
      }

      [Token(Token = "0x170009BA")]
      public AssetCachedSpawner.LoadRequest.RequestState State
      {
        [Token(Token = "0x600432E"), Address(RVA = "0x363F9F4", Offset = "0x363F9F4", VA = "0x363F9F4")] get
        {
          return new AssetCachedSpawner.LoadRequest.RequestState();
        }
        [Token(Token = "0x600432F"), Address(RVA = "0x363F9FC", Offset = "0x363F9FC", VA = "0x363F9FC")] set
        {
        }
      }

      [Token(Token = "0x6004330")]
      [Address(RVA = "0x363FA04", Offset = "0x363FA04", VA = "0x363FA04")]
      public LoadRequest(
        string key,
        string assetBundleName,
        string assetName,
        AssetSpawnOperationBase operation,
        bool isPreload = false)
      {
      }

      [Token(Token = "0x2000BBF")]
      public enum RequestState
      {
        [Token(Token = "0x400359D")] StartWait,
        [Token(Token = "0x400359E")] Loading,
        [Token(Token = "0x400359F")] Complete,
      }
    }

    [Token(Token = "0x2000BC0")]
    private class CacheParameter
    {
      [Token(Token = "0x170009BB")]
      public string Key
      {
        [Token(Token = "0x6004331"), Address(RVA = "0x363FB38", Offset = "0x363FB38", VA = "0x363FB38")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6004332"), Address(RVA = "0x363FB40", Offset = "0x363FB40", VA = "0x363FB40")] private set
        {
        }
      }

      [Token(Token = "0x170009BC")]
      public UnityEngine.Object Asset
      {
        [Token(Token = "0x6004333"), Address(RVA = "0x363FB48", Offset = "0x363FB48", VA = "0x363FB48")] get
        {
          return (UnityEngine.Object) null;
        }
        [Token(Token = "0x6004334"), Address(RVA = "0x363FB50", Offset = "0x363FB50", VA = "0x363FB50")] private set
        {
        }
      }

      [Token(Token = "0x170009BD")]
      public int Generation
      {
        [Token(Token = "0x6004335"), Address(RVA = "0x363FB58", Offset = "0x363FB58", VA = "0x363FB58")] get
        {
          return new int();
        }
        [Token(Token = "0x6004336"), Address(RVA = "0x363FB60", Offset = "0x363FB60", VA = "0x363FB60")] private set
        {
        }
      }

      [Token(Token = "0x6004337")]
      [Address(RVA = "0x363F028", Offset = "0x363F028", VA = "0x363F028")]
      public CacheParameter(string key, UnityEngine.Object asset)
      {
      }

      [Token(Token = "0x6004338")]
      [Address(RVA = "0x363F5B4", Offset = "0x363F5B4", VA = "0x363F5B4")]
      public void NextGeneration(int count)
      {
      }

      [Token(Token = "0x6004339")]
      [Address(RVA = "0x363F5AC", Offset = "0x363F5AC", VA = "0x363F5AC")]
      public void ClearGeneration()
      {
      }
    }
  }
}
