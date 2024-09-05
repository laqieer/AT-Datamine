// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapBackGroundTemporarySceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x2001887")]
  public class FreeMapBackGroundTemporarySceneLoader : IFreeMapTemporarySceneLoader
  {
    [Token(Token = "0x4006AAE")]
    private const string MapLinkCameraName = "LinkCamera";
    [Token(Token = "0x4006AAF")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapSceneHolder mapLoader;
    [Token(Token = "0x4006AB0")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapResourceLoader resourceLoader;
    [Token(Token = "0x4006AB1")]
    [FieldOffset(Offset = "0x20")]
    private List<IFreeMapRegistBackgroundCamera> registList;
    [Token(Token = "0x4006AB2")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapManager freeMapManager;

    [Token(Token = "0x6008B57")]
    [Address(RVA = "0x4526A5C", Offset = "0x4526A5C", VA = "0x4526A5C")]
    public FreeMapBackGroundTemporarySceneLoader(
      FreeMapResourceLoader resourceLoader,
      FreeMapSceneHolder mapLoader,
      List<IFreeMapRegistBackgroundCamera> registList,
      FreeMapManager freeMapManager)
    {
    }

    [Token(Token = "0x6008B58")]
    [Address(RVA = "0x4526A9C", Offset = "0x4526A9C", VA = "0x4526A9C", Slot = "4")]
    public void UnLoadScene()
    {
    }

    [Token(Token = "0x6008B59")]
    [Address(RVA = "0x4526DB4", Offset = "0x4526DB4", VA = "0x4526DB4", Slot = "5")]
    public IEnumerator LoadScene() => (IEnumerator) null;
  }
}
