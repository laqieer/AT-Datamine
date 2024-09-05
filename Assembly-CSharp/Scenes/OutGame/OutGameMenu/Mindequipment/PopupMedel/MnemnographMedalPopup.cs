// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.MnemnographMedalPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003C02")]
  public class MnemnographMedalPopup : PopupBase
  {
    [Token(Token = "0x40109E2")]
    private const string AssetBundleName = "ui_page_mnemnographlist";
    [Token(Token = "0x40109E3")]
    private const string AssetName = "Com_Popup_Base_M_MnemnographMedal";
    [Token(Token = "0x40109E4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private MnemnographMedalPresenter _presenter;

    [Token(Token = "0x601796C")]
    [Address(RVA = "0x237DA80", Offset = "0x237DA80", VA = "0x237DA80")]
    public static IEnumerator RequestAsync(
      AssetCachedSpawner assetCachedSpawner,
      MindEquipment mindEquipment,
      Action<MnemnographMedalPopup> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17004CA6")]
    public Action<ConversionContext> OnSuccessConvertion
    {
      [Token(Token = "0x601796D"), Address(RVA = "0x237DB24", Offset = "0x237DB24", VA = "0x237DB24")] get
      {
        return (Action<ConversionContext>) null;
      }
      [Token(Token = "0x601796E"), Address(RVA = "0x237DB64", Offset = "0x237DB64", VA = "0x237DB64")] set
      {
      }
    }

    [Token(Token = "0x601796F")]
    [Address(RVA = "0x237DBA4", Offset = "0x237DBA4", VA = "0x237DBA4")]
    private void Initialize(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6017970")]
    [Address(RVA = "0x237E114", Offset = "0x237E114", VA = "0x237E114")]
    private void InitializeAndOpen(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6017971")]
    [Address(RVA = "0x237E280", Offset = "0x237E280", VA = "0x237E280")]
    public MnemnographMedalPopup()
    {
    }
  }
}
