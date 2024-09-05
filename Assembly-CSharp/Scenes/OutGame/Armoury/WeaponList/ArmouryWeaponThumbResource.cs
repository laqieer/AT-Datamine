// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.ArmouryWeaponThumbResource
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
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x2003829")]
  internal class ArmouryWeaponThumbResource : 
    IArmouryWeaponThumbResource,
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x400F50B")]
    [FieldOffset(Offset = "0x10")]
    private readonly WeaponThumbResource resource;
    [Token(Token = "0x400F50C")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> onChangeFavorite;
    [Token(Token = "0x400F50D")]
    [FieldOffset(Offset = "0x20")]
    private Action onUpdateView;

    [Token(Token = "0x170048E8")]
    public IEquipmentListAssetLoader AssetLoader
    {
      [Token(Token = "0x6016130"), Address(RVA = "0x20F0AD4", Offset = "0x20F0AD4", VA = "0x20F0AD4")] get
      {
        return (IEquipmentListAssetLoader) null;
      }
    }

    [Token(Token = "0x170048E9")]
    public bool NowEquipped
    {
      [Token(Token = "0x6016131"), Address(RVA = "0x20F0B0C", Offset = "0x20F0B0C", VA = "0x20F0B0C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170048EA")]
    public bool IsSelected
    {
      [Token(Token = "0x6016132"), Address(RVA = "0x20F0BBC", Offset = "0x20F0BBC", VA = "0x20F0BBC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170048EB")]
    public Weapon WeaponData
    {
      [Token(Token = "0x6016133"), Address(RVA = "0x20F0AF0", Offset = "0x20F0AF0", VA = "0x20F0AF0", Slot = "4")] get
      {
        return (Weapon) null;
      }
    }

    [Token(Token = "0x170048EC")]
    public bool IsNew
    {
      [Token(Token = "0x6016134"), Address(RVA = "0x20F0B28", Offset = "0x20F0B28", VA = "0x20F0B28", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170048ED")]
    public EquipmentSortCondition SortCondition
    {
      [Token(Token = "0x6016135"), Address(RVA = "0x20F0E9C", Offset = "0x20F0E9C", VA = "0x20F0E9C")] get
      {
        return new EquipmentSortCondition();
      }
    }

    [Token(Token = "0x170048EE")]
    public SortIconLoader SortIconLoader
    {
      [Token(Token = "0x6016136"), Address(RVA = "0x20F0EA4", Offset = "0x20F0EA4", VA = "0x20F0EA4")] get
      {
        return (SortIconLoader) null;
      }
    }

    [Token(Token = "0x6016137")]
    [Address(RVA = "0x20F0EAC", Offset = "0x20F0EAC", VA = "0x20F0EAC")]
    public ArmouryWeaponThumbResource(
      bool nowEquipped,
      bool isNew,
      Weapon weaponData,
      IEquipmentListAssetLoader assetLoader,
      Action<int> onClickThumbnail,
      EquipmentSortCondition equipmentSortCondition,
      SortIconLoader sortIconLoader)
    {
    }

    [Token(Token = "0x6016138")]
    [Address(RVA = "0x20F0F74", Offset = "0x20F0F74", VA = "0x20F0F74", Slot = "6")]
    public void ChangeNew(bool isNew)
    {
    }

    [Token(Token = "0x6016139")]
    [Address(RVA = "0x20F0FE8", Offset = "0x20F0FE8", VA = "0x20F0FE8", Slot = "7")]
    public void ChangeSelected(bool selected)
    {
    }

    [Token(Token = "0x601613A")]
    [Address(RVA = "0x20F105C", Offset = "0x20F105C", VA = "0x20F105C", Slot = "8")]
    public void ChangeFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x601613B")]
    [Address(RVA = "0x20F107C", Offset = "0x20F107C", VA = "0x20F107C", Slot = "9")]
    public void Update()
    {
    }

    [Token(Token = "0x601613C")]
    [Address(RVA = "0x20F0E68", Offset = "0x20F0E68", VA = "0x20F0E68")]
    public void OnClickThumb(int dataIndex)
    {
    }

    [Token(Token = "0x601613D")]
    [Address(RVA = "0x20F0B44", Offset = "0x20F0B44", VA = "0x20F0B44")]
    public void AddListenerDoChangeNew(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x601613E")]
    [Address(RVA = "0x20F0BD8", Offset = "0x20F0BD8", VA = "0x20F0BD8")]
    public void AddListenerDoSelected(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x601613F")]
    [Address(RVA = "0x20F1098", Offset = "0x20F1098", VA = "0x20F1098")]
    public void SetActionChangeFavorite(Action<bool> call)
    {
    }

    [Token(Token = "0x6016140")]
    [Address(RVA = "0x20F10A0", Offset = "0x20F10A0", VA = "0x20F10A0")]
    public void SetActionUpdateView(Action call)
    {
    }
  }
}
