// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.ArmouryAccessoryThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using StaqData.Sort;
using System;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x20038A8")]
  internal class ArmouryAccessoryThumbResource : 
    IArmouryAccessoryThumbResource,
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x400F7D0")]
    [FieldOffset(Offset = "0x10")]
    private readonly AccessoryThumbResource resource;
    [Token(Token = "0x400F7D1")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> onChangeFavorite;
    [Token(Token = "0x400F7D2")]
    [FieldOffset(Offset = "0x20")]
    private Action onUpdateView;

    [Token(Token = "0x1700495D")]
    public IEquipmentListAssetLoader AssetLoader
    {
      [Token(Token = "0x6016458"), Address(RVA = "0x1E010A4", Offset = "0x1E010A4", VA = "0x1E010A4")] get
      {
        return (IEquipmentListAssetLoader) null;
      }
    }

    [Token(Token = "0x1700495E")]
    public bool NowEquipped
    {
      [Token(Token = "0x6016459"), Address(RVA = "0x1E010C0", Offset = "0x1E010C0", VA = "0x1E010C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700495F")]
    public bool IsSelected
    {
      [Token(Token = "0x601645A"), Address(RVA = "0x1E01170", Offset = "0x1E01170", VA = "0x1E01170")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004960")]
    public Accessory AccessoryData
    {
      [Token(Token = "0x601645B"), Address(RVA = "0x1E01088", Offset = "0x1E01088", VA = "0x1E01088", Slot = "4")] get
      {
        return (Accessory) null;
      }
    }

    [Token(Token = "0x17004961")]
    public bool IsNew
    {
      [Token(Token = "0x601645C"), Address(RVA = "0x1E010DC", Offset = "0x1E010DC", VA = "0x1E010DC", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004962")]
    public EquipmentSortCondition SortCondition
    {
      [Token(Token = "0x601645D"), Address(RVA = "0x1E01470", Offset = "0x1E01470", VA = "0x1E01470")] get
      {
        return new EquipmentSortCondition();
      }
    }

    [Token(Token = "0x17004963")]
    public SortIconLoader SortIconLoader
    {
      [Token(Token = "0x601645E"), Address(RVA = "0x1E01478", Offset = "0x1E01478", VA = "0x1E01478")] get
      {
        return (SortIconLoader) null;
      }
    }

    [Token(Token = "0x601645F")]
    [Address(RVA = "0x1DFE408", Offset = "0x1DFE408", VA = "0x1DFE408")]
    public ArmouryAccessoryThumbResource(
      bool nowEquipped,
      bool isNew,
      Accessory accessoryData,
      IEquipmentListAssetLoader assetLoader,
      Action<int> onClickThumbnail,
      EquipmentSortCondition equipmentSortCondition,
      SortIconLoader sortIconLoader)
    {
    }

    [Token(Token = "0x6016460")]
    [Address(RVA = "0x1E01480", Offset = "0x1E01480", VA = "0x1E01480", Slot = "6")]
    public void ChangeNew(bool isNew)
    {
    }

    [Token(Token = "0x6016461")]
    [Address(RVA = "0x1E014F4", Offset = "0x1E014F4", VA = "0x1E014F4", Slot = "7")]
    public void ChangeSelected(bool selected)
    {
    }

    [Token(Token = "0x6016462")]
    [Address(RVA = "0x1E0155C", Offset = "0x1E0155C", VA = "0x1E0155C", Slot = "8")]
    public void ChangeFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x6016463")]
    [Address(RVA = "0x1E0157C", Offset = "0x1E0157C", VA = "0x1E0157C", Slot = "9")]
    public void Update()
    {
    }

    [Token(Token = "0x6016464")]
    [Address(RVA = "0x1E0143C", Offset = "0x1E0143C", VA = "0x1E0143C")]
    public void OnClickThumb(int dataIndex)
    {
    }

    [Token(Token = "0x6016465")]
    [Address(RVA = "0x1E010F8", Offset = "0x1E010F8", VA = "0x1E010F8")]
    public void AddListenerDoChangeNew(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x6016466")]
    [Address(RVA = "0x1E0118C", Offset = "0x1E0118C", VA = "0x1E0118C")]
    public void AddListenerDoSelected(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x6016467")]
    [Address(RVA = "0x1E01598", Offset = "0x1E01598", VA = "0x1E01598")]
    public void SetActionChangeFavorite(Action<bool> call)
    {
    }

    [Token(Token = "0x6016468")]
    [Address(RVA = "0x1E015A0", Offset = "0x1E015A0", VA = "0x1E015A0")]
    public void SetActionUpdateView(Action call)
    {
    }
  }
}
