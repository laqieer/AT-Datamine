// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.ContentLotteryResultItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200367C")]
  public class ContentLotteryResultItem : MonoBehaviour
  {
    [Token(Token = "0x400ED02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image selectImage;
    [Token(Token = "0x400ED04")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ContainerIconOptionEffect[] containerIconOptionEffects;

    [Token(Token = "0x1700472A")]
    public Image SelectImage
    {
      [Token(Token = "0x6015709"), Address(RVA = "0x18E3750", Offset = "0x18E3750", VA = "0x18E3750")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x1700472B")]
    public int Index
    {
      [Token(Token = "0x601570A"), Address(RVA = "0x18E3758", Offset = "0x18E3758", VA = "0x18E3758")] get
      {
        return new int();
      }
      [Token(Token = "0x601570B"), Address(RVA = "0x18E3760", Offset = "0x18E3760", VA = "0x18E3760")] set
      {
      }
    }

    [Token(Token = "0x601570C")]
    [Address(RVA = "0x18E3768", Offset = "0x18E3768", VA = "0x18E3768")]
    public void SetWeaponOptionEffect(
      AssetCachedSpawner assetCachedSpawner,
      PlayerGearOptionCandidateType playerGearOptionCandidateType)
    {
    }

    [Token(Token = "0x601570D")]
    [Address(RVA = "0x18E3828", Offset = "0x18E3828", VA = "0x18E3828")]
    public void SetAccessoryOptionEffect(
      AssetCachedSpawner assetCachedSpawner,
      PlayerGearOptionCandidateType playerGearOptionCandidateType)
    {
    }

    [Token(Token = "0x601570E")]
    [Address(RVA = "0x18E38E8", Offset = "0x18E38E8", VA = "0x18E38E8")]
    public ContentLotteryResultItem()
    {
    }
  }
}
