// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographLimitBreakEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036E5")]
  public class MnemnographLimitBreakEffect : LimitBreakEffectBase
  {
    [Token(Token = "0x400EF8F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private DetailSkillListThumb skillThumb;
    [Token(Token = "0x400EF90")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI prevText;
    [Token(Token = "0x400EF91")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text resultText;
    [Token(Token = "0x400EF92")]
    [FieldOffset(Offset = "0x78")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60159F1")]
    [Address(RVA = "0x1D7DF5C", Offset = "0x1D7DF5C", VA = "0x1D7DF5C")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      MindEquipment dispMnemnograph,
      int limitBreakNum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60159F2")]
    [Address(RVA = "0x1D7E010", Offset = "0x1D7E010", VA = "0x1D7E010")]
    public MnemnographLimitBreakEffect()
    {
    }
  }
}
