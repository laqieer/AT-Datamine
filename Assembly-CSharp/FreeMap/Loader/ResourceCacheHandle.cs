// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.ResourceCacheHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x2001882")]
  public struct ResourceCacheHandle
  {
    [Token(Token = "0x4006A98")]
    public const int InvalidID = -1;
    [Token(Token = "0x4006A99")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ResourceCacheHandle Invalid;
    [Token(Token = "0x4006A9A")]
    [FieldOffset(Offset = "0x0")]
    private FreeMapResourceCacheManager manager;
    [Token(Token = "0x4006A9B")]
    [FieldOffset(Offset = "0x8")]
    private int id;

    [Token(Token = "0x1700163C")]
    public int ID
    {
      [Token(Token = "0x6008B24"), Address(RVA = "0x4525B44", Offset = "0x4525B44", VA = "0x4525B44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700163D")]
    public bool IsValid
    {
      [Token(Token = "0x6008B25"), Address(RVA = "0x4525B4C", Offset = "0x4525B4C", VA = "0x4525B4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008B26")]
    [Address(RVA = "0x4525B70", Offset = "0x4525B70", VA = "0x4525B70")]
    public ResourceCacheHandle(int id, FreeMapResourceCacheManager manager)
    {
    }

    [Token(Token = "0x6008B27")]
    [Address(RVA = "0x4525B7C", Offset = "0x4525B7C", VA = "0x4525B7C")]
    public bool IsRented() => new bool();

    [Token(Token = "0x6008B28")]
    public T GetResource<T>() where T : Object => (T) null;

    [Token(Token = "0x6008B29")]
    [Address(RVA = "0x4525CAC", Offset = "0x4525CAC", VA = "0x4525CAC")]
    public void Release()
    {
    }

    [Token(Token = "0x6008B2A")]
    [Address(RVA = "0x4525DE8", Offset = "0x4525DE8", VA = "0x4525DE8")]
    static ResourceCacheHandle()
    {
    }
  }
}
