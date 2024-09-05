// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.SpriteAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x200177C")]
  public class SpriteAssetLoader : IFreeMapResourceElement
  {
    [Token(Token = "0x17001507")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008526"), Address(RVA = "0x406AB20", Offset = "0x406AB20", VA = "0x406AB20", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x17001508")]
    public string AssetBundleName
    {
      [Token(Token = "0x6008527"), Address(RVA = "0x406AB28", Offset = "0x406AB28", VA = "0x406AB28")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001509")]
    public string AssetName
    {
      [Token(Token = "0x6008528"), Address(RVA = "0x406AB30", Offset = "0x406AB30", VA = "0x406AB30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700150A")]
    public string SpriteName
    {
      [Token(Token = "0x6008529"), Address(RVA = "0x406AB38", Offset = "0x406AB38", VA = "0x406AB38")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700150B")]
    public Sprite SpriteAsset
    {
      [Token(Token = "0x600852A"), Address(RVA = "0x406AB40", Offset = "0x406AB40", VA = "0x406AB40")] protected set
      {
      }
      [Token(Token = "0x600852B"), Address(RVA = "0x406AB48", Offset = "0x406AB48", VA = "0x406AB48")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x600852C")]
    [Address(RVA = "0x4067E48", Offset = "0x4067E48", VA = "0x4067E48")]
    public SpriteAssetLoader(string assetBundleName, string assetName, string spriteName)
    {
    }

    [Token(Token = "0x600852D")]
    [Address(RVA = "0x4068B74", Offset = "0x4068B74", VA = "0x4068B74", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x600852E")]
    [Address(RVA = "0x406AB50", Offset = "0x406AB50", VA = "0x406AB50", Slot = "6")]
    public void Build()
    {
    }

    [Token(Token = "0x600852F")]
    [Address(RVA = "0x4068DBC", Offset = "0x4068DBC", VA = "0x4068DBC")]
    public void Release()
    {
    }

    [Token(Token = "0x6008530")]
    [Address(RVA = "0x406AB54", Offset = "0x406AB54", VA = "0x406AB54")]
    private void LoadCallback(SpriteAtlas asset)
    {
    }
  }
}
