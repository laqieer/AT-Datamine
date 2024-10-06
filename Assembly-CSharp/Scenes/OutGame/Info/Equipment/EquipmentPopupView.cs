// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentPopupView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x20035A7")]
  public class EquipmentPopupView
  {
    [Token(Token = "0x1700464A")]
    public EquipmentTitleUI TitleUI
    {
      [Token(Token = "0x60151CE"), Address(RVA = "0x4AAC438", Offset = "0x4AAC438", VA = "0x4AAC438")] private get
      {
        return (EquipmentTitleUI) null;
      }
      [Token(Token = "0x60151CF"), Address(RVA = "0x4AAC440", Offset = "0x4AAC440", VA = "0x4AAC440")] set
      {
      }
    }

    [Token(Token = "0x1700464B")]
    public EquipmentFlavorUI FlavorUI
    {
      [Token(Token = "0x60151D0"), Address(RVA = "0x4AAC448", Offset = "0x4AAC448", VA = "0x4AAC448")] private get
      {
        return (EquipmentFlavorUI) null;
      }
      [Token(Token = "0x60151D1"), Address(RVA = "0x4AAC450", Offset = "0x4AAC450", VA = "0x4AAC450")] set
      {
      }
    }

    [Token(Token = "0x1700464C")]
    public EquipmentThumbnailUI ThumbnailUI
    {
      [Token(Token = "0x60151D2"), Address(RVA = "0x4AAC458", Offset = "0x4AAC458", VA = "0x4AAC458")] private get
      {
        return (EquipmentThumbnailUI) null;
      }
      [Token(Token = "0x60151D3"), Address(RVA = "0x4AAC460", Offset = "0x4AAC460", VA = "0x4AAC460")] set
      {
      }
    }

    [Token(Token = "0x1700464D")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x60151D4"), Address(RVA = "0x4AAC468", Offset = "0x4AAC468", VA = "0x4AAC468")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60151D5"), Address(RVA = "0x4AAC470", Offset = "0x4AAC470", VA = "0x4AAC470")] set
      {
      }
    }

    [Token(Token = "0x1700464E")]
    public GameObject MemoryTab
    {
      [Token(Token = "0x60151D6"), Address(RVA = "0x4AAC478", Offset = "0x4AAC478", VA = "0x4AAC478")] private get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x60151D7"), Address(RVA = "0x4AAC480", Offset = "0x4AAC480", VA = "0x4AAC480")] set
      {
      }
    }

    [Token(Token = "0x60151D8")]
    [Address(RVA = "0x4AA1A5C", Offset = "0x4AA1A5C", VA = "0x4AA1A5C")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60151D9")]
    [Address(RVA = "0x4AA9C98", Offset = "0x4AA9C98", VA = "0x4AA9C98")]
    public void SetRarity(RarityTypeEnum rarity)
    {
    }

    [Token(Token = "0x60151DA")]
    [Address(RVA = "0x4AA9E40", Offset = "0x4AA9E40", VA = "0x4AA9E40")]
    public void SetFlavor(string text)
    {
    }

    [Token(Token = "0x60151DB")]
    [Address(RVA = "0x4AAC4AC", Offset = "0x4AAC4AC", VA = "0x4AAC4AC")]
    public void SetEquipmentThumbnail(Sprite sprite)
    {
    }

    [Token(Token = "0x60151DC")]
    [Address(RVA = "0x4AA4514", Offset = "0x4AA4514", VA = "0x4AA4514")]
    public EquipmentPopupView()
    {
    }
  }
}
