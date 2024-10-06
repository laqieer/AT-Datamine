// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleParameterProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AD5")]
  public class StyleParameterProvider
  {
    [Token(Token = "0x4010311")]
    private const string ASSET_BUNDLE_STYLE_STATUS = "ui_page_stylestatus";
    [Token(Token = "0x4010312")]
    private const string ASSET_STYLE_PARAMETER = "Container_StyleParameter";

    [Token(Token = "0x6017252")]
    [Address(RVA = "0x300D4E4", Offset = "0x300D4E4", VA = "0x300D4E4")]
    public static IEnumerator RequestAndWait(
      AssetCachedSpawner spawner,
      Character character,
      bool fromArmoury = true,
      Action<StyleContainerParameter.eStyleContainerParameterEnd> finish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017253")]
    [Address(RVA = "0x300D59C", Offset = "0x300D59C", VA = "0x300D59C")]
    public static IEnumerator RequestAndWait(
      AssetCachedSpawner spawner,
      Style style,
      bool fromArmoury = true,
      Action<StyleContainerParameter.eStyleContainerParameterEnd> finish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017254")]
    [Address(RVA = "0x300D638", Offset = "0x300D638", VA = "0x300D638")]
    private static AssetSpawnOperation<GameObject> Create(
      AssetCachedSpawner spawner,
      Action<StyleContainerParameter> callback = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6017255")]
    [Address(RVA = "0x300D748", Offset = "0x300D748", VA = "0x300D748")]
    public StyleParameterProvider()
    {
    }
  }
}
