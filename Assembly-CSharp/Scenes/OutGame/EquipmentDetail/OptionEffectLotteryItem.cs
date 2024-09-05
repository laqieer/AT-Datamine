// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.OptionEffectLotteryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003688")]
  public class OptionEffectLotteryItem : MonoBehaviour
  {
    [Token(Token = "0x400ED43")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContainerIconOptionEffect icon;
    [Token(Token = "0x400ED44")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text detailText;

    [Token(Token = "0x601574A")]
    [Address(RVA = "0x18E5928", Offset = "0x18E5928", VA = "0x18E5928")]
    public void Initialize(
      string assetName,
      int optionGrade,
      string name,
      float min,
      float max,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601574B")]
    [Address(RVA = "0x18E5B4C", Offset = "0x18E5B4C", VA = "0x18E5B4C")]
    public OptionEffectLotteryItem()
    {
    }
  }
}
