// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.ArmouryItemThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x200386A")]
  internal class ArmouryItemThumbResource : 
    IArmouryItemThumbResource,
    INewModified,
    ISelectModified,
    IAmountChangedModified
  {
    [Token(Token = "0x400F657")]
    [FieldOffset(Offset = "0x28")]
    private readonly Action<int> onClickThumbnail;
    [Token(Token = "0x400F658")]
    [FieldOffset(Offset = "0x30")]
    private readonly UnityEvent<bool> onChangeSelected;
    [Token(Token = "0x400F659")]
    [FieldOffset(Offset = "0x38")]
    private readonly UnityEvent<bool> onChangeNew;
    [Token(Token = "0x400F65A")]
    [FieldOffset(Offset = "0x40")]
    private Action<int> onChangeAmount;

    [Token(Token = "0x17004927")]
    public Item ItemData
    {
      [Token(Token = "0x60162C2"), Address(RVA = "0x1DEF790", Offset = "0x1DEF790", VA = "0x1DEF790", Slot = "4")] get
      {
        return (Item) null;
      }
    }

    [Token(Token = "0x17004928")]
    public ItemListAssetLoader AssetLoader
    {
      [Token(Token = "0x60162C3"), Address(RVA = "0x1DEF798", Offset = "0x1DEF798", VA = "0x1DEF798")] get
      {
        return (ItemListAssetLoader) null;
      }
      [Token(Token = "0x60162C4"), Address(RVA = "0x1DEF7A0", Offset = "0x1DEF7A0", VA = "0x1DEF7A0")] private set
      {
      }
    }

    [Token(Token = "0x17004929")]
    public bool NowEquipped
    {
      [Token(Token = "0x60162C5"), Address(RVA = "0x1DEF7A8", Offset = "0x1DEF7A8", VA = "0x1DEF7A8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60162C6"), Address(RVA = "0x1DEF7B0", Offset = "0x1DEF7B0", VA = "0x1DEF7B0")] private set
      {
      }
    }

    [Token(Token = "0x1700492A")]
    public bool IsNew
    {
      [Token(Token = "0x60162C7"), Address(RVA = "0x1DEF7BC", Offset = "0x1DEF7BC", VA = "0x1DEF7BC", Slot = "5")] get
      {
        return new bool();
      }
      [Token(Token = "0x60162C8"), Address(RVA = "0x1DEF7C4", Offset = "0x1DEF7C4", VA = "0x1DEF7C4")] private set
      {
      }
    }

    [Token(Token = "0x1700492B")]
    public bool IsSelected
    {
      [Token(Token = "0x60162C9"), Address(RVA = "0x1DEF7D0", Offset = "0x1DEF7D0", VA = "0x1DEF7D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60162CA"), Address(RVA = "0x1DEF7D8", Offset = "0x1DEF7D8", VA = "0x1DEF7D8")] private set
      {
      }
    }

    [Token(Token = "0x60162CB")]
    [Address(RVA = "0x1DEF7E4", Offset = "0x1DEF7E4", VA = "0x1DEF7E4")]
    public ArmouryItemThumbResource(
      bool nowEquipped,
      bool isNew,
      Item itemData,
      ItemListAssetLoader assetLoader,
      Action<int> onClickThumbnail)
    {
    }

    [Token(Token = "0x60162CC")]
    [Address(RVA = "0x1DEF8C4", Offset = "0x1DEF8C4", VA = "0x1DEF8C4", Slot = "6")]
    public void ChangeNew(bool isNew)
    {
    }

    [Token(Token = "0x60162CD")]
    [Address(RVA = "0x1DEF928", Offset = "0x1DEF928", VA = "0x1DEF928", Slot = "7")]
    public void ChangeSelected(bool isSelected)
    {
    }

    [Token(Token = "0x60162CE")]
    [Address(RVA = "0x1DEF694", Offset = "0x1DEF694", VA = "0x1DEF694")]
    public void OnClickThumb(int dataIndex)
    {
    }

    [Token(Token = "0x60162CF")]
    [Address(RVA = "0x1DEF260", Offset = "0x1DEF260", VA = "0x1DEF260")]
    public void AddListenerDoChangeNew(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x60162D0")]
    [Address(RVA = "0x1DEF2C8", Offset = "0x1DEF2C8", VA = "0x1DEF2C8")]
    public void AddListenerDoSelected(UnityAction<bool> call)
    {
    }

    [Token(Token = "0x60162D1")]
    [Address(RVA = "0x1DEF98C", Offset = "0x1DEF98C", VA = "0x1DEF98C")]
    public void SetOnChangeAmount(Action<int> call)
    {
    }

    [Token(Token = "0x60162D2")]
    [Address(RVA = "0x1DEF994", Offset = "0x1DEF994", VA = "0x1DEF994", Slot = "8")]
    public void OnChangeAmount(int amount)
    {
    }
  }
}
