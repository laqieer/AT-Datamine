// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUICanvasUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015FA")]
  public static class FreeMapUICanvasUtility
  {
    [Token(Token = "0x4006432")]
    private const string DrawCanvasAssetBundleLabel = "freemap_prefabs";
    [Token(Token = "0x4006433")]
    private const string DrawCanvasAssetName = "FreeMapCanvas";

    [Token(Token = "0x1700132A")]
    public static Canvas DrawCanvas
    {
      [Token(Token = "0x6007C5B"), Address(RVA = "0x21A0AA4", Offset = "0x21A0AA4", VA = "0x21A0AA4")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x1700132B")]
    public static UISafeAreaInsets UISafeArea
    {
      [Token(Token = "0x6007C5C"), Address(RVA = "0x21A0AF8", Offset = "0x21A0AF8", VA = "0x21A0AF8")] get
      {
        return (UISafeAreaInsets) null;
      }
    }

    [Token(Token = "0x1700132C")]
    public static RectTransform CanvasRectTransform
    {
      [Token(Token = "0x6007C5D"), Address(RVA = "0x21A0B4C", Offset = "0x21A0B4C", VA = "0x21A0B4C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x1700132D")]
    public static FreeMapUICanvasGetterContainer CanvasGetter
    {
      [Token(Token = "0x6007C5E"), Address(RVA = "0x21A0BA8", Offset = "0x21A0BA8", VA = "0x21A0BA8")] get
      {
        return (FreeMapUICanvasGetterContainer) null;
      }
      [Token(Token = "0x6007C5F"), Address(RVA = "0x21A0BF0", Offset = "0x21A0BF0", VA = "0x21A0BF0")] private set
      {
      }
    }

    [Token(Token = "0x6007C60")]
    [Address(RVA = "0x21A0C3C", Offset = "0x21A0C3C", VA = "0x21A0C3C")]
    public static IEnumerator CanvasLoadAsync(Transform parent) => (IEnumerator) null;

    [Token(Token = "0x6007C61")]
    [Address(RVA = "0x21A0CCC", Offset = "0x21A0CCC", VA = "0x21A0CCC")]
    public static void DestroyCanvas()
    {
    }

    [Token(Token = "0x20015FB")]
    public class CanvasGetterReference
    {
      [Token(Token = "0x1700132E")]
      public FreeMapUICanvasGetterContainer CanvasGetter
      {
        [Token(Token = "0x6007C62"), Address(RVA = "0x21A0D64", Offset = "0x21A0D64", VA = "0x21A0D64")] get
        {
          return (FreeMapUICanvasGetterContainer) null;
        }
      }

      [Token(Token = "0x6007C63")]
      [Address(RVA = "0x21A0DA4", Offset = "0x21A0DA4", VA = "0x21A0DA4")]
      public CanvasGetterReference()
      {
      }
    }
  }
}
