// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReincarnationEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A8B")]
  public class StyleReincarnationEffect : EnhanceEffectBase
  {
    [Token(Token = "0x40100E9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI beforeLevel;
    [Token(Token = "0x40100EA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text afterLevel;
    [Token(Token = "0x40100EB")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Image unitTrustImage;
    [Token(Token = "0x40100EC")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image unitTrustBase;
    [Token(Token = "0x40100ED")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image unitTrustRarityImage;
    [Token(Token = "0x40100EE")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI unitTrustName;
    [Token(Token = "0x40100EF")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40100F0")]
    [FieldOffset(Offset = "0x88")]
    private Style dispStyle;

    [Token(Token = "0x6017032")]
    [Address(RVA = "0x29CC754", Offset = "0x29CC754", VA = "0x29CC754")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Style dispStyle,
      int beforeLv)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017033")]
    [Address(RVA = "0x29CCC80", Offset = "0x29CCC80", VA = "0x29CCC80")]
    public IEnumerator InitializeAsyncMemory(
      AssetCachedSpawner assetCachedSpawner,
      Style dispStyle,
      int beforeLv)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017034")]
    [Address(RVA = "0x29CCD34", Offset = "0x29CCD34", VA = "0x29CCD34")]
    private void SetAnim(StyleReincarnationEffect.BonusType type)
    {
    }

    [Token(Token = "0x6017035")]
    [Address(RVA = "0x29CCE14", Offset = "0x29CCE14", VA = "0x29CCE14")]
    private IEnumerator SetUnitTrust() => (IEnumerator) null;

    [Token(Token = "0x6017036")]
    [Address(RVA = "0x29CCEA4", Offset = "0x29CCEA4", VA = "0x29CCEA4")]
    public StyleReincarnationEffect()
    {
    }

    [Token(Token = "0x2003A8C")]
    private enum BonusType
    {
      [Token(Token = "0x40100F2")] Nothing,
      [Token(Token = "0x40100F3")] Slot,
      [Token(Token = "0x40100F4")] Trust,
    }
  }
}
