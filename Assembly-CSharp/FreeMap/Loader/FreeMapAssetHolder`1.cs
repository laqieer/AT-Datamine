// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapAssetHolder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x2001886")]
  public class FreeMapAssetHolder<T> : IFreeMapResourceElement where T : UnityEngine.Object
  {
    [Token(Token = "0x4006AAC")]
    [FieldOffset(Offset = "0x0")]
    private string assetName;
    [Token(Token = "0x4006AAD")]
    [FieldOffset(Offset = "0x0")]
    private string assetBundleName;

    [Token(Token = "0x17001643")]
    public bool IsValid
    {
      [Token(Token = "0x6008B4A")] get => new bool();
    }

    [Token(Token = "0x1400011A")]
    public event Action<T> OnBuild
    {
      [Token(Token = "0x6008B4B")] add
      {
      }
      [Token(Token = "0x6008B4C")] remove
      {
      }
    }

    [Token(Token = "0x17001644")]
    public T LoadedObject
    {
      [Token(Token = "0x6008B4D")] private set
      {
      }
      [Token(Token = "0x6008B4E")] get => (T) null;
    }

    [Token(Token = "0x17001645")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008B4F")] set
      {
      }
      [Token(Token = "0x6008B50")] get => new FreeMapBuildOrder();
    }

    [Token(Token = "0x6008B51")]
    public void Setup(string assetBundleName, string assetName)
    {
    }

    [Token(Token = "0x6008B52")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008B53")]
    public void Build()
    {
    }

    [Token(Token = "0x6008B54")]
    private void LoadCallback(T asset)
    {
    }

    [Token(Token = "0x6008B55")]
    public void Release()
    {
    }

    [Token(Token = "0x6008B56")]
    public FreeMapAssetHolder()
    {
    }
  }
}
