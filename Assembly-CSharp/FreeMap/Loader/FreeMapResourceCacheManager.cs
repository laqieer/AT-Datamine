// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapResourceCacheManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x2001883")]
  public sealed class FreeMapResourceCacheManager
  {
    [Token(Token = "0x4006A9C")]
    private const string CacheObjectName = "ModelCache";
    [Token(Token = "0x4006A9D")]
    private const int AliveGeneration = 1;
    [Token(Token = "0x4006A9F")]
    [FieldOffset(Offset = "0x18")]
    private GameObject cacheParent;

    [Token(Token = "0x1700163E")]
    private List<FreeMapResourceCacheManager.Element> Elements
    {
      [Token(Token = "0x6008B2B"), Address(RVA = "0x4525E38", Offset = "0x4525E38", VA = "0x4525E38")] set
      {
      }
      [Token(Token = "0x6008B2C"), Address(RVA = "0x4525E40", Offset = "0x4525E40", VA = "0x4525E40")] get
      {
        return (List<FreeMapResourceCacheManager.Element>) null;
      }
    }

    [Token(Token = "0x1700163F")]
    private int ElementCounter
    {
      [Token(Token = "0x6008B2D"), Address(RVA = "0x4525E48", Offset = "0x4525E48", VA = "0x4525E48")] set
      {
      }
      [Token(Token = "0x6008B2E"), Address(RVA = "0x4525E50", Offset = "0x4525E50", VA = "0x4525E50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008B2F")]
    [Address(RVA = "0x4525E58", Offset = "0x4525E58", VA = "0x4525E58")]
    public FreeMapResourceCacheManager(Transform parent)
    {
    }

    [Token(Token = "0x6008B30")]
    private FreeMapResourceCacheManager.Element RegisterInternal<T>(
      string assetBundleName,
      string assetName,
      T instance)
      where T : UnityEngine.Object
    {
      return (FreeMapResourceCacheManager.Element) null;
    }

    [Token(Token = "0x6008B31")]
    public void Register<T>(string assetBundleName, string assetName, T instance) where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x6008B32")]
    public ResourceCacheHandle RegisterAndRent<T>(
      string assetBundleName,
      string assetName,
      T instance)
      where T : UnityEngine.Object
    {
      return new ResourceCacheHandle();
    }

    [Token(Token = "0x6008B33")]
    [Address(RVA = "0x4525BF8", Offset = "0x4525BF8", VA = "0x4525BF8")]
    public bool IsRented(ResourceCacheHandle handle) => new bool();

    [Token(Token = "0x6008B34")]
    [Address(RVA = "0x45260C4", Offset = "0x45260C4", VA = "0x45260C4")]
    public bool TryRentResource(
      string assetBundleName,
      string assetName,
      System.Type type,
      out ResourceCacheHandle handle)
    {
      return new bool();
    }

    [Token(Token = "0x6008B35")]
    public T GetResource<T>(ResourceCacheHandle handle) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x6008B36")]
    [Address(RVA = "0x4525D24", Offset = "0x4525D24", VA = "0x4525D24")]
    public void ReturnResource(ResourceCacheHandle handle)
    {
    }

    [Token(Token = "0x6008B37")]
    [Address(RVA = "0x4526414", Offset = "0x4526414", VA = "0x4526414")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008B38")]
    [Address(RVA = "0x45265E8", Offset = "0x45265E8", VA = "0x45265E8")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6008B39")]
    [Address(RVA = "0x4525F44", Offset = "0x4525F44", VA = "0x4525F44")]
    private bool TryGetElement(
      ref ResourceCacheHandle handle,
      out FreeMapResourceCacheManager.Element element)
    {
      return new bool();
    }

    [Token(Token = "0x6008B3A")]
    [Address(RVA = "0x4526194", Offset = "0x4526194", VA = "0x4526194")]
    private bool TryGetElement(
      string assetBundleName,
      string assetName,
      System.Type type,
      bool exclusionRented,
      out FreeMapResourceCacheManager.Element element)
    {
      return new bool();
    }

    [Token(Token = "0x2001884")]
    private class ElementKey
    {
      [Token(Token = "0x4006AA1")]
      [FieldOffset(Offset = "0x10")]
      public string assetBundleName;
      [Token(Token = "0x4006AA2")]
      [FieldOffset(Offset = "0x18")]
      public string assetName;
      [Token(Token = "0x4006AA3")]
      [FieldOffset(Offset = "0x20")]
      public System.Type type;

      [Token(Token = "0x6008B3B")]
      [Address(RVA = "0x45268E4", Offset = "0x45268E4", VA = "0x45268E4")]
      public ElementKey(string assetBundleName, string assetName, System.Type type)
      {
      }

      [Token(Token = "0x6008B3C")]
      [Address(RVA = "0x4526834", Offset = "0x4526834", VA = "0x4526834")]
      public bool IsMatch(string assetBundleName, string assetName, System.Type type) => new bool();
    }

    [Token(Token = "0x2001885")]
    private class Element
    {
      [Token(Token = "0x4006AA4")]
      [FieldOffset(Offset = "0x10")]
      private readonly int ID;
      [Token(Token = "0x4006AA5")]
      [FieldOffset(Offset = "0x14")]
      private int generation;
      [Token(Token = "0x4006AA6")]
      [FieldOffset(Offset = "0x18")]
      private UnityEngine.Object resource;

      [Token(Token = "0x17001640")]
      public FreeMapResourceCacheManager.ElementKey Key
      {
        [Token(Token = "0x6008B3D"), Address(RVA = "0x4526920", Offset = "0x4526920", VA = "0x4526920")] private set
        {
        }
        [Token(Token = "0x6008B3E"), Address(RVA = "0x4526928", Offset = "0x4526928", VA = "0x4526928")] get
        {
          return (FreeMapResourceCacheManager.ElementKey) null;
        }
      }

      [Token(Token = "0x17001641")]
      public bool IsValid
      {
        [Token(Token = "0x6008B3F"), Address(RVA = "0x45267D4", Offset = "0x45267D4", VA = "0x45267D4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001642")]
      public bool IsRented
      {
        [Token(Token = "0x6008B40"), Address(RVA = "0x4526930", Offset = "0x4526930", VA = "0x4526930")] private set
        {
        }
        [Token(Token = "0x6008B41"), Address(RVA = "0x452693C", Offset = "0x452693C", VA = "0x452693C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6008B42")]
      [Address(RVA = "0x4526944", Offset = "0x4526944", VA = "0x4526944")]
      public Element(
        int id,
        FreeMapResourceCacheManager.ElementKey key,
        UnityEngine.Object resource,
        Transform parent)
      {
      }

      [Token(Token = "0x6008B43")]
      [Address(RVA = "0x4526768", Offset = "0x4526768", VA = "0x4526768")]
      public bool IsMatch(ref ResourceCacheHandle handle) => new bool();

      [Token(Token = "0x6008B44")]
      [Address(RVA = "0x4526370", Offset = "0x4526370", VA = "0x4526370")]
      public ResourceCacheHandle Rent(FreeMapResourceCacheManager manager)
      {
        return new ResourceCacheHandle();
      }

      [Token(Token = "0x6008B45")]
      public TCast GetResource<TCast>() where TCast : UnityEngine.Object => (TCast) null;

      [Token(Token = "0x6008B46")]
      [Address(RVA = "0x45263F8", Offset = "0x45263F8", VA = "0x45263F8")]
      public void Return(Transform parent)
      {
      }

      [Token(Token = "0x6008B47")]
      [Address(RVA = "0x4526514", Offset = "0x4526514", VA = "0x4526514")]
      public bool UpdateGeneration() => new bool();

      [Token(Token = "0x6008B48")]
      [Address(RVA = "0x4526558", Offset = "0x4526558", VA = "0x4526558")]
      public void Destroy()
      {
      }

      [Token(Token = "0x6008B49")]
      [Address(RVA = "0x4526990", Offset = "0x4526990", VA = "0x4526990")]
      private void EscapeGameObject(UnityEngine.Object obj, Transform parent)
      {
      }
    }
  }
}
