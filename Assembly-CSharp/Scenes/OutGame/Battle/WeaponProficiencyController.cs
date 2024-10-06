// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.WeaponProficiencyController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Effect;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x20037AF")]
  internal class WeaponProficiencyController : MonoBehaviour
  {
    [Token(Token = "0x400F373")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider weaponProficiencyExpSlider;
    [Token(Token = "0x400F374")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image weaponImage;
    [Token(Token = "0x400F375")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI rank;
    [Token(Token = "0x400F376")]
    [FieldOffset(Offset = "0x0")]
    private static string ProficiencyIconAssetBundle;

    [Token(Token = "0x6015EC3")]
    [Address(RVA = "0x2323270", Offset = "0x2323270", VA = "0x2323270")]
    public IEnumerator PlayWeaponProficiency(
      GaugeUpControl gaugeUpControl,
      List<UnitView.stWeaponProficiency> list,
      UITweenGroup tweenGroup,
      AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015EC4")]
    [Address(RVA = "0x23287E0", Offset = "0x23287E0", VA = "0x23287E0")]
    private IEnumerator LoadProficiencyIcon(int type, AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015EC5")]
    [Address(RVA = "0x2328884", Offset = "0x2328884", VA = "0x2328884")]
    public WeaponProficiencyController()
    {
    }

    [Token(Token = "0x6015EC6")]
    [Address(RVA = "0x232888C", Offset = "0x232888C", VA = "0x232888C")]
    static WeaponProficiencyController()
    {
    }
  }
}
