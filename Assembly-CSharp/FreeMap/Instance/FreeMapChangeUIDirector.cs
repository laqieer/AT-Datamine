// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapChangeUIDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Builder;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x2001903")]
  public class FreeMapChangeUIDirector : IFreeMapResourceElement
  {
    [Token(Token = "0x170016C5")]
    private FreeMapUIBase UIInstance
    {
      [Token(Token = "0x6008E14"), Address(RVA = "0x4AFD460", Offset = "0x4AFD460", VA = "0x4AFD460")] get
      {
        return (FreeMapUIBase) null;
      }
    }

    [Token(Token = "0x170016C6")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008E15"), Address(RVA = "0x4AFD468", Offset = "0x4AFD468", VA = "0x4AFD468", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x170016C7")]
    private SpriteAssetLoader SpriteAssetLoader
    {
      [Token(Token = "0x6008E16"), Address(RVA = "0x4AFD470", Offset = "0x4AFD470", VA = "0x4AFD470")] get
      {
        return (SpriteAssetLoader) null;
      }
    }

    [Token(Token = "0x170016C8")]
    private FreeMapUIParamBase FromParam
    {
      [Token(Token = "0x6008E17"), Address(RVA = "0x4AFD478", Offset = "0x4AFD478", VA = "0x4AFD478")] get
      {
        return (FreeMapUIParamBase) null;
      }
    }

    [Token(Token = "0x170016C9")]
    private FreeMapUIParamBase ToParam
    {
      [Token(Token = "0x6008E18"), Address(RVA = "0x4AFD480", Offset = "0x4AFD480", VA = "0x4AFD480")] get
      {
        return (FreeMapUIParamBase) null;
      }
    }

    [Token(Token = "0x170016CA")]
    private UnityAction ButtonAction
    {
      [Token(Token = "0x6008E19"), Address(RVA = "0x4AFD488", Offset = "0x4AFD488", VA = "0x4AFD488")] get
      {
        return (UnityAction) null;
      }
    }

    [Token(Token = "0x170016CB")]
    private string ButtonObjectName
    {
      [Token(Token = "0x6008E1A"), Address(RVA = "0x4AFD490", Offset = "0x4AFD490", VA = "0x4AFD490")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6008E1B")]
    [Address(RVA = "0x4AFD498", Offset = "0x4AFD498", VA = "0x4AFD498")]
    public FreeMapChangeUIDirector(
      FreeMapUIBase uiInstance,
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam,
      UnityAction buttonAction,
      string spriteAtlasAssetBundleName,
      string spriteAtlasAssetName,
      string buttonObjectName)
    {
    }

    [Token(Token = "0x6008E1C")]
    [Address(RVA = "0x4AFD570", Offset = "0x4AFD570", VA = "0x4AFD570", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008E1D")]
    [Address(RVA = "0x4AFD58C", Offset = "0x4AFD58C", VA = "0x4AFD58C", Slot = "6")]
    public void Build()
    {
    }
  }
}
