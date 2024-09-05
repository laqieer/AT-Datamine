// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.ArmouryMindEquipmentThumbResource
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
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x2003851")]
  internal class ArmouryMindEquipmentThumbResource : 
    IArmouryMindEquipmentThumbResource,
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x400F5D9")]
    [FieldOffset(Offset = "0x10")]
    private readonly MindequipmentThumbResource resource;
    [Token(Token = "0x400F5DA")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> onChangeFavorite;
    [Token(Token = "0x400F5DB")]
    [FieldOffset(Offset = "0x20")]
    private Action onUpdateView;

    [Token(Token = "0x17004910")]
    public IEquipmentListAssetLoader AssetLoader
    {
      [Token(Token = "0x601622E"), Address(RVA = "0x20F9804", Offset = "0x20F9804", VA = "0x20F9804")] get
      {
        return (IEquipmentListAssetLoader) null;
      }
    }

    [Token(Token = "0x17004911")]
    public MindEquipment MindEquipmentData
    {
      [Token(Token = "0x601622F"), Address(RVA = "0x20F9820", Offset = "0x20F9820", VA = "0x20F9820", Slot = "5")] get
      {
        return (MindEquipment) null;
      }
    }

    [Token(Token = "0x17004912")]
    public bool NowEquipped
    {
      [Token(Token = "0x6016230"), Address(RVA = "0x20F9F1C", Offset = "0x20F9F1C", VA = "0x20F9F1C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004913")]
    public bool IsNew
    {
      [Token(Token = "0x6016231"), Address(RVA = "0x20F9F38", Offset = "0x20F9F38", VA = "0x20F9F38", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004914")]
    public bool IsSelected
    {
      [Token(Token = "0x6016232"), Address(RVA = "0x20F9FCC", Offset = "0x20F9FCC", VA = "0x20F9FCC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004915")]
    public EquipmentSortCondition SortCondition
    {
      [Token(Token = "0x6016233"), Address(RVA = "0x20FA320", Offset = "0x20FA320", VA = "0x20FA320")] get
      {
        return new EquipmentSortCondition();
      }
    }

    [Token(Token = "0x17004916")]
    public SortIconLoader SortIconLoader
    {
      [Token(Token = "0x6016234"), Address(RVA = "0x20FA328", Offset = "0x20FA328", VA = "0x20FA328")] get
      {
        return (SortIconLoader) null;
      }
    }

    [Token(Token = "0x17004917")]
    public bool IsPossessing
    {
      [Token(Token = "0x6016235"), Address(RVA = "0x20FA330", Offset = "0x20FA330", VA = "0x20FA330", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6016236")]
    [Address(RVA = "0x20FA338", Offset = "0x20FA338", VA = "0x20FA338")]
    public ArmouryMindEquipmentThumbResource(
      bool possessing,
      bool nowEquipped,
      bool isNew,
      MindEquipment mindEquipmentData,
      IEquipmentListAssetLoader assetLoader,
      Action<int> onClickThumbnail,
      EquipmentSortCondition equipmentSortCondition,
      SortIconLoader sortIconLoader)
    {
    }

    [Token(Token = "0x6016237")]
    [Address(RVA = "0x20FA40C", Offset = "0x20FA40C", VA = "0x20FA40C", Slot = "7")]
    public void ChangeNew(bool isNew)
    {
    }

    [Token(Token = "0x6016238")]
    [Address(RVA = "0x20FA480", Offset = "0x20FA480", VA = "0x20FA480", Slot = "8")]
    public void ChangeSelected(bool selected)
    {
    }

    [Token(Token = "0x6016239")]
    [Address(RVA = "0x20FA4E8", Offset = "0x20FA4E8", VA = "0x20FA4E8", Slot = "9")]
    public void ChangeFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x601623A")]
    [Address(RVA = "0x20FA508", Offset = "0x20FA508", VA = "0x20FA508", Slot = "10")]
    public void Update()
    {
    }

    [Token(Token = "0x601623B")]
    [Address(RVA = "0x20FA2C4", Offset = "0x20FA2C4", VA = "0x20FA2C4")]
    public void OnClickThumb(int dataIndex)
    {
    }

    [Token(Token = "0x601623C")]
    [Address(RVA = "0x20F9F54", Offset = "0x20F9F54", VA = "0x20F9F54")]
    public void AddListenerDoChangeNew(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x601623D")]
    [Address(RVA = "0x20F9FE8", Offset = "0x20F9FE8", VA = "0x20F9FE8")]
    public void AddListenerDoSelected(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x601623E")]
    [Address(RVA = "0x20FA524", Offset = "0x20FA524", VA = "0x20FA524")]
    public void SetActionOnChangeFavorite(Action<bool> call)
    {
    }

    [Token(Token = "0x601623F")]
    [Address(RVA = "0x20FA52C", Offset = "0x20FA52C", VA = "0x20FA52C")]
    public void SetActionUpdateView(Action call)
    {
    }
  }
}
