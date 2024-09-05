// Decompiled with JetBrains decompiler
// Type: Battle.Asset.AssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Asset
{
  [Token(Token = "0x20022BD")]
  public class AssetLoader : Singleton<AssetLoader>
  {
    [Token(Token = "0x4009271")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, List<AssetLoader.CachedAsset>> assetDic;

    [Token(Token = "0x600D3E3")]
    public T LoadAsset<T>(string abName, string assetPath) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x600D3E4")]
    [Address(RVA = "0x19DB604", Offset = "0x19DB604", VA = "0x19DB604")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x600D3E5")]
    [Address(RVA = "0x19DB654", Offset = "0x19DB654", VA = "0x19DB654")]
    public AssetLoader()
    {
    }

    [Token(Token = "0x20022BE")]
    public class CachedAsset
    {
      [Token(Token = "0x17002DE8")]
      public string abName
      {
        [Token(Token = "0x600D3E6"), Address(RVA = "0x19DB6E4", Offset = "0x19DB6E4", VA = "0x19DB6E4")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600D3E7"), Address(RVA = "0x19DB6EC", Offset = "0x19DB6EC", VA = "0x19DB6EC")] set
        {
        }
      }

      [Token(Token = "0x17002DE9")]
      public string assetPath
      {
        [Token(Token = "0x600D3E8"), Address(RVA = "0x19DB6F4", Offset = "0x19DB6F4", VA = "0x19DB6F4")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600D3E9"), Address(RVA = "0x19DB6FC", Offset = "0x19DB6FC", VA = "0x19DB6FC")] set
        {
        }
      }

      [Token(Token = "0x17002DEA")]
      public WeakReference<UnityEngine.Object> assetRef
      {
        [Token(Token = "0x600D3EA"), Address(RVA = "0x19DB704", Offset = "0x19DB704", VA = "0x19DB704")] get
        {
          return (WeakReference<UnityEngine.Object>) null;
        }
        [Token(Token = "0x600D3EB"), Address(RVA = "0x19DB70C", Offset = "0x19DB70C", VA = "0x19DB70C")] set
        {
        }
      }

      [Token(Token = "0x600D3EC")]
      [Address(RVA = "0x19DB714", Offset = "0x19DB714", VA = "0x19DB714")]
      public CachedAsset()
      {
      }
    }
  }
}
