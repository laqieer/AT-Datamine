// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.StyleMasterList.ArmouryStyleMasterThumbResource
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
namespace Scenes.OutGame.Armoury.StyleMasterList
{
  [Token(Token = "0x200383F")]
  internal class ArmouryStyleMasterThumbResource : 
    IArmouryStyleMasterThumbResource,
    INewModified,
    ISelectModified,
    IFavoriteModified
  {
    [Token(Token = "0x400F57A")]
    [FieldOffset(Offset = "0x10")]
    private readonly TrustThumbResource resource;
    [Token(Token = "0x400F57B")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> onChangeFavorite;

    [Token(Token = "0x170048FD")]
    public IEquipmentListAssetLoader AssetLoader
    {
      [Token(Token = "0x60161B7"), Address(RVA = "0x20F5AE8", Offset = "0x20F5AE8", VA = "0x20F5AE8")] get
      {
        return (IEquipmentListAssetLoader) null;
      }
    }

    [Token(Token = "0x170048FE")]
    public UnitTrust UnitTrustData
    {
      [Token(Token = "0x60161B8"), Address(RVA = "0x20F5ACC", Offset = "0x20F5ACC", VA = "0x20F5ACC", Slot = "4")] get
      {
        return (UnitTrust) null;
      }
    }

    [Token(Token = "0x170048FF")]
    public bool NowEquipped
    {
      [Token(Token = "0x60161B9"), Address(RVA = "0x20F5B04", Offset = "0x20F5B04", VA = "0x20F5B04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004900")]
    public bool IsNew
    {
      [Token(Token = "0x60161BA"), Address(RVA = "0x20F5B20", Offset = "0x20F5B20", VA = "0x20F5B20", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004901")]
    public bool IsSelected
    {
      [Token(Token = "0x60161BB"), Address(RVA = "0x20F5BB4", Offset = "0x20F5BB4", VA = "0x20F5BB4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004902")]
    public EquipmentSortCondition SortCondition
    {
      [Token(Token = "0x60161BC"), Address(RVA = "0x20F5D40", Offset = "0x20F5D40", VA = "0x20F5D40")] get
      {
        return new EquipmentSortCondition();
      }
    }

    [Token(Token = "0x17004903")]
    public SortIconLoader SortIconLoader
    {
      [Token(Token = "0x60161BD"), Address(RVA = "0x20F5D48", Offset = "0x20F5D48", VA = "0x20F5D48")] get
      {
        return (SortIconLoader) null;
      }
    }

    [Token(Token = "0x60161BE")]
    [Address(RVA = "0x20F5D50", Offset = "0x20F5D50", VA = "0x20F5D50")]
    public ArmouryStyleMasterThumbResource(
      bool nowEquipped,
      bool isNew,
      UnitTrust unitTrustData,
      IEquipmentListAssetLoader assetLoader,
      Action<int> onClickThumbnail,
      EquipmentSortCondition equipmentSortCondition,
      SortIconLoader sortIconLoader)
    {
    }

    [Token(Token = "0x60161BF")]
    [Address(RVA = "0x20F5E18", Offset = "0x20F5E18", VA = "0x20F5E18", Slot = "6")]
    public void ChangeNew(bool isNew)
    {
    }

    [Token(Token = "0x60161C0")]
    [Address(RVA = "0x20F5E8C", Offset = "0x20F5E8C", VA = "0x20F5E8C", Slot = "7")]
    public void ChangeSelected(bool selected)
    {
    }

    [Token(Token = "0x60161C1")]
    [Address(RVA = "0x20F5EF4", Offset = "0x20F5EF4", VA = "0x20F5EF4", Slot = "8")]
    public void ChangeFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x60161C2")]
    [Address(RVA = "0x20F5D0C", Offset = "0x20F5D0C", VA = "0x20F5D0C")]
    public void OnClickThumb(int dataIndex)
    {
    }

    [Token(Token = "0x60161C3")]
    [Address(RVA = "0x20F5B3C", Offset = "0x20F5B3C", VA = "0x20F5B3C")]
    public void AddListenerDoChangeNew(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x60161C4")]
    [Address(RVA = "0x20F5BD0", Offset = "0x20F5BD0", VA = "0x20F5BD0")]
    public void AddListenerDoSelected(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x60161C5")]
    [Address(RVA = "0x20F5F14", Offset = "0x20F5F14", VA = "0x20F5F14")]
    public void SetActionOnChangeFavorite(Action<bool> call)
    {
    }
  }
}
