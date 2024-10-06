// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaRewardConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200310A")]
  public class ArenaRewardConfirmPopup : PopupBase
  {
    [Token(Token = "0x400D0C7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400D0C8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ToggleGroup toggleGroup;
    [Token(Token = "0x400D0C9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ArenaRewardConfirmRankItem rankItemPrefab;
    [Token(Token = "0x400D0CA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private List<ArenaRewardConfirmPopup.Switcher> switchers;
    [Token(Token = "0x400D0CB")]
    [FieldOffset(Offset = "0xA8")]
    private ArenaLoader loader;
    [Token(Token = "0x400D0CC")]
    [FieldOffset(Offset = "0xB0")]
    private List<ArenaRewardConfirmRankItem> dailyItems;
    [Token(Token = "0x400D0CD")]
    [FieldOffset(Offset = "0xB8")]
    private List<ArenaRewardConfirmRankItem> weeklyItems;
    [Token(Token = "0x400D0CE")]
    [FieldOffset(Offset = "0xC0")]
    private (int id, int from, int to)[] dailySetData;
    [Token(Token = "0x400D0CF")]
    [FieldOffset(Offset = "0xC8")]
    private (int id, int from, int to)[] weeklySetData;
    [Token(Token = "0x400D0D0")]
    [FieldOffset(Offset = "0xD0")]
    private (int id, (ItemUtility.Parameter param, int quantity)[] rewards)[] dailyRewardData;
    [Token(Token = "0x400D0D1")]
    [FieldOffset(Offset = "0xD8")]
    private (int id, (ItemUtility.Parameter param, int quantity)[] rewards)[] weeklyRewardData;

    [Token(Token = "0x6013277")]
    [Address(RVA = "0x45DFCE0", Offset = "0x45DFCE0", VA = "0x45DFCE0")]
    public IEnumerator InitializeWithOpen(ArenaLoader loader) => (IEnumerator) null;

    [Token(Token = "0x6013278")]
    [Address(RVA = "0x45DFD7C", Offset = "0x45DFD7C", VA = "0x45DFD7C", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6013279")]
    [Address(RVA = "0x45DFD84", Offset = "0x45DFD84", VA = "0x45DFD84", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601327A")]
    [Address(RVA = "0x45DFD8C", Offset = "0x45DFD8C", VA = "0x45DFD8C")]
    private void ChangeToggleState()
    {
    }

    [Token(Token = "0x601327B")]
    [Address(RVA = "0x45DFE2C", Offset = "0x45DFE2C", VA = "0x45DFE2C")]
    private void CreateOrActivate(ArenaRewardConfirmPopup.DisplayType type)
    {
    }

    [Token(Token = "0x601327C")]
    [Address(RVA = "0x45E03DC", Offset = "0x45E03DC", VA = "0x45E03DC")]
    private (int, int, int)[] GetRewardSetData(ArenaRewardConfirmPopup.DisplayType type)
    {
      return ((int, int, int)[]) null;
    }

    [Token(Token = "0x601327D")]
    [Address(RVA = "0x45E0AB4", Offset = "0x45E0AB4", VA = "0x45E0AB4")]
    private (int, (ItemUtility.Parameter, int)[]) GetRewards(
      ArenaRewardConfirmPopup.DisplayType type,
      int id)
    {
      return ();
    }

    [Token(Token = "0x601327E")]
    [Address(RVA = "0x45E0F3C", Offset = "0x45E0F3C", VA = "0x45E0F3C")]
    public ArenaRewardConfirmPopup()
    {
    }

    [Token(Token = "0x200310B")]
    public enum DisplayType
    {
      [Token(Token = "0x400D0D3")] Daily,
      [Token(Token = "0x400D0D4")] Weekly,
    }

    [Token(Token = "0x200310C")]
    [Serializable]
    public class Switcher
    {
      [Token(Token = "0x400D0D5")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private ArenaRewardConfirmPopup.DisplayType type;
      [Token(Token = "0x400D0D6")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private CommonToggle toggle;
      [Token(Token = "0x400D0D7")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private GameObject onObj;
      [Token(Token = "0x400D0D8")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private GameObject offObj;

      [Token(Token = "0x17004036")]
      public ArenaRewardConfirmPopup.DisplayType DisplayType
      {
        [Token(Token = "0x6013284"), Address(RVA = "0x45E1130", Offset = "0x45E1130", VA = "0x45E1130")] get
        {
          return new ArenaRewardConfirmPopup.DisplayType();
        }
      }

      [Token(Token = "0x17004037")]
      public CommonToggle Toggle
      {
        [Token(Token = "0x6013285"), Address(RVA = "0x45E1138", Offset = "0x45E1138", VA = "0x45E1138")] get
        {
          return (CommonToggle) null;
        }
      }

      [Token(Token = "0x6013286")]
      [Address(RVA = "0x45E10E8", Offset = "0x45E10E8", VA = "0x45E10E8")]
      public void OnActive(bool isOn)
      {
      }

      [Token(Token = "0x6013287")]
      [Address(RVA = "0x45E1140", Offset = "0x45E1140", VA = "0x45E1140")]
      public Switcher()
      {
      }
    }
  }
}
