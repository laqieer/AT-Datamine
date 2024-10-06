// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.IconPrefabAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x200177B")]
  public class IconPrefabAssetLoader
  {
    [Token(Token = "0x17001504")]
    public string AssetBundleName
    {
      [Token(Token = "0x600851E"), Address(RVA = "0x406A978", Offset = "0x406A978", VA = "0x406A978")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001505")]
    public string AssetName
    {
      [Token(Token = "0x600851F"), Address(RVA = "0x406A980", Offset = "0x406A980", VA = "0x406A980")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001506")]
    public GameObject IconPrefab
    {
      [Token(Token = "0x6008520"), Address(RVA = "0x406A988", Offset = "0x406A988", VA = "0x406A988")] protected set
      {
      }
      [Token(Token = "0x6008521"), Address(RVA = "0x406A990", Offset = "0x406A990", VA = "0x406A990")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6008522")]
    [Address(RVA = "0x4067E84", Offset = "0x4067E84", VA = "0x4067E84")]
    public IconPrefabAssetLoader(string assetBundleName, string assetName)
    {
    }

    [Token(Token = "0x6008523")]
    [Address(RVA = "0x4068C98", Offset = "0x4068C98", VA = "0x4068C98")]
    public void Load(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008524")]
    [Address(RVA = "0x4068DC4", Offset = "0x4068DC4", VA = "0x4068DC4")]
    public void Release()
    {
    }

    [Token(Token = "0x6008525")]
    [Address(RVA = "0x406A998", Offset = "0x406A998", VA = "0x406A998")]
    private void LoadCallback(GameObject asset)
    {
    }
  }
}
