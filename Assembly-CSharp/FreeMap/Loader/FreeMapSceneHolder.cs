// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapSceneHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x200189B")]
  public class FreeMapSceneHolder : IFreeMapResourceElement
  {
    [Token(Token = "0x4006AF6")]
    [FieldOffset(Offset = "0x10")]
    public Action<Scene> OnLoadedScene;
    [Token(Token = "0x4006AFA")]
    [FieldOffset(Offset = "0x30")]
    protected AsyncOperation loadingAsyncOperation;

    [Token(Token = "0x17001661")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008BB7"), Address(RVA = "0x4528FDC", Offset = "0x4528FDC", VA = "0x4528FDC", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x17001662")]
    public bool IsValid
    {
      [Token(Token = "0x6008BB8"), Address(RVA = "0x4528FE4", Offset = "0x4528FE4", VA = "0x4528FE4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001663")]
    public Scene LoadedScene
    {
      [Token(Token = "0x6008BB9"), Address(RVA = "0x4529008", Offset = "0x4529008", VA = "0x4529008")] get
      {
        return new Scene();
      }
      [Token(Token = "0x6008BBA"), Address(RVA = "0x4529010", Offset = "0x4529010", VA = "0x4529010")] private set
      {
      }
    }

    [Token(Token = "0x17001664")]
    public string SceneName
    {
      [Token(Token = "0x6008BBB"), Address(RVA = "0x4529018", Offset = "0x4529018", VA = "0x4529018")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008BBC"), Address(RVA = "0x4529020", Offset = "0x4529020", VA = "0x4529020")] private set
      {
      }
    }

    [Token(Token = "0x17001665")]
    public string AssetBundleName
    {
      [Token(Token = "0x6008BBD"), Address(RVA = "0x4529028", Offset = "0x4529028", VA = "0x4529028")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008BBE"), Address(RVA = "0x4529030", Offset = "0x4529030", VA = "0x4529030")] private set
      {
      }
    }

    [Token(Token = "0x6008BBF")]
    [Address(RVA = "0x4529038", Offset = "0x4529038", VA = "0x4529038")]
    public void Setup(string assetBundleName, string sceneName)
    {
    }

    [Token(Token = "0x6008BC0")]
    [Address(RVA = "0x4529040", Offset = "0x4529040", VA = "0x4529040", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008BC1")]
    [Address(RVA = "0x45291FC", Offset = "0x45291FC", VA = "0x45291FC", Slot = "6")]
    public void Build()
    {
    }

    [Token(Token = "0x6008BC2")]
    [Address(RVA = "0x4529200", Offset = "0x4529200", VA = "0x4529200")]
    public IEnumerator LoadSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6008BC3")]
    [Address(RVA = "0x4526C70", Offset = "0x4526C70", VA = "0x4526C70")]
    public void Release(bool isUnloadUnusedAssets = true)
    {
    }

    [Token(Token = "0x6008BC4")]
    [Address(RVA = "0x4529298", Offset = "0x4529298", VA = "0x4529298")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6008BC5")]
    [Address(RVA = "0x45272B8", Offset = "0x45272B8", VA = "0x45272B8")]
    public bool SetActiveLoadedScene() => new bool();

    [Token(Token = "0x6008BC6")]
    [Address(RVA = "0x45292D4", Offset = "0x45292D4", VA = "0x45292D4")]
    public void MoveGameObjectToLoadingScene(GameObject target)
    {
    }

    [Token(Token = "0x6008BC7")]
    public T GetComponentInSceneRootObject<T>() where T : Behaviour => (T) null;

    [Token(Token = "0x6008BC8")]
    public T GetComponentInSceneRootObject<T>(string name) where T : Behaviour => (T) null;

    [Token(Token = "0x6008BC9")]
    [Address(RVA = "0x452935C", Offset = "0x452935C", VA = "0x452935C")]
    public Scene GetLoadedScene() => new Scene();

    [Token(Token = "0x6008BCA")]
    [Address(RVA = "0x4529364", Offset = "0x4529364", VA = "0x4529364")]
    public FreeMapSceneHolder()
    {
    }
  }
}
