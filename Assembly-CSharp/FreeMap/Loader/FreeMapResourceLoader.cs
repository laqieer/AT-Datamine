// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapResourceLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x2001895")]
  public class FreeMapResourceLoader
  {
    [Token(Token = "0x4006AE3")]
    [FieldOffset(Offset = "0x20")]
    private Queue<FreeMapResourceElementContainer> containerPool;

    [Token(Token = "0x17001657")]
    private MonoBehaviour CoroutineOwner
    {
      [Token(Token = "0x6008B94"), Address(RVA = "0x4527C24", Offset = "0x4527C24", VA = "0x4527C24")] get
      {
        return (MonoBehaviour) null;
      }
    }

    [Token(Token = "0x17001658")]
    private Coroutine LoadCoroutine
    {
      [Token(Token = "0x6008B95"), Address(RVA = "0x4527C2C", Offset = "0x4527C2C", VA = "0x4527C2C")] set
      {
      }
      [Token(Token = "0x6008B96"), Address(RVA = "0x4527C34", Offset = "0x4527C34", VA = "0x4527C34")] get
      {
        return (Coroutine) null;
      }
    }

    [Token(Token = "0x17001659")]
    private FreeMapResourceCacheManager RefCacheManager
    {
      [Token(Token = "0x6008B97"), Address(RVA = "0x4527C3C", Offset = "0x4527C3C", VA = "0x4527C3C")] get
      {
        return (FreeMapResourceCacheManager) null;
      }
    }

    [Token(Token = "0x1700165A")]
    private FreeMapResourceElementContainer CurrentContainer
    {
      [Token(Token = "0x6008B98"), Address(RVA = "0x4527C44", Offset = "0x4527C44", VA = "0x4527C44")] get
      {
        return (FreeMapResourceElementContainer) null;
      }
    }

    [Token(Token = "0x1700165B")]
    private Queue<FreeMapResourceElementContainer> LoadQueue
    {
      [Token(Token = "0x6008B99"), Address(RVA = "0x4527D18", Offset = "0x4527D18", VA = "0x4527D18")] get
      {
        return (Queue<FreeMapResourceElementContainer>) null;
      }
    }

    [Token(Token = "0x6008B9A")]
    [Address(RVA = "0x4527D20", Offset = "0x4527D20", VA = "0x4527D20")]
    public FreeMapResourceLoader(
      MonoBehaviour coroutineOwner,
      FreeMapResourceCacheManager cacheManager)
    {
    }

    [Token(Token = "0x6008B9B")]
    [Address(RVA = "0x4527110", Offset = "0x4527110", VA = "0x4527110")]
    public void RegistElement(IFreeMapResourceElement element)
    {
    }

    [Token(Token = "0x6008B9C")]
    [Address(RVA = "0x45271C4", Offset = "0x45271C4", VA = "0x45271C4")]
    public FreeMapResourceLoader.Handle Load() => new FreeMapResourceLoader.Handle();

    [Token(Token = "0x6008B9D")]
    [Address(RVA = "0x4527DDC", Offset = "0x4527DDC", VA = "0x4527DDC")]
    public void Update()
    {
    }

    [Token(Token = "0x6008B9E")]
    [Address(RVA = "0x4527EF0", Offset = "0x4527EF0", VA = "0x4527EF0")]
    public void Release()
    {
    }

    [Token(Token = "0x6008B9F")]
    [Address(RVA = "0x4527E78", Offset = "0x4527E78", VA = "0x4527E78")]
    private IEnumerator LoadInternal(FreeMapResourceElementContainer container)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008BA0")]
    public T GetAsset<T>(string assetBundleName, string assetName) where T : Object => (T) null;

    [Token(Token = "0x2001896")]
    public struct Handle
    {
      [Token(Token = "0x4006AE6")]
      [FieldOffset(Offset = "0x0")]
      private FreeMapResourceElementContainer container;

      [Token(Token = "0x6008BA1")]
      [Address(RVA = "0x4528098", Offset = "0x4528098", VA = "0x4528098")]
      public Handle(FreeMapResourceElementContainer container)
      {
      }

      [Token(Token = "0x6008BA2")]
      [Address(RVA = "0x452724C", Offset = "0x452724C", VA = "0x452724C")]
      public IEnumerator WaitLoad() => (IEnumerator) null;

      [Token(Token = "0x1700165C")]
      public bool IsLoaded
      {
        [Token(Token = "0x6008BA3"), Address(RVA = "0x45280C8", Offset = "0x45280C8", VA = "0x45280C8")] get
        {
          return new bool();
        }
      }
    }
  }
}
