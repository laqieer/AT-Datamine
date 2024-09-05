// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleRarityUpEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A7D")]
  public class StyleRarityUpEffect : EnhanceEffectBase
  {
    [Token(Token = "0x401007D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] rarityStar;
    [Token(Token = "0x401007E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private StyleRarityUpEffect.ChangeParam[] changeParams;
    [Token(Token = "0x401007F")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6016FC9")]
    [Address(RVA = "0x29C7280", Offset = "0x29C7280", VA = "0x29C7280")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner, Style dispStyle)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016FCA")]
    [Address(RVA = "0x29C7374", Offset = "0x29C7374", VA = "0x29C7374")]
    public StyleRarityUpEffect()
    {
    }

    [Token(Token = "0x2003A7E")]
    [Serializable]
    private class ChangeParam
    {
      [Token(Token = "0x4010080")]
      [FieldOffset(Offset = "0x10")]
      public GameObject groupTop;
      [Token(Token = "0x4010081")]
      [FieldOffset(Offset = "0x18")]
      public Text bonusType;
      [Token(Token = "0x4010082")]
      [FieldOffset(Offset = "0x20")]
      public TextMeshProUGUI prevParam;
      [Token(Token = "0x4010083")]
      [FieldOffset(Offset = "0x28")]
      public Text resultParam;

      [Token(Token = "0x6016FCC")]
      [Address(RVA = "0x29C7384", Offset = "0x29C7384", VA = "0x29C7384")]
      public ChangeParam()
      {
      }
    }
  }
}
