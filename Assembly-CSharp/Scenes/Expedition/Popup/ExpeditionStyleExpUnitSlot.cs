// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionStyleExpUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Expedition.Main;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C8E")]
  public class ExpeditionStyleExpUnitSlot : MonoBehaviour
  {
    [Token(Token = "0x400BE01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController uiTimeline;
    [Token(Token = "0x400BE02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button styleThumbButton;
    [Token(Token = "0x400BE03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400BE04")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject levelObj;
    [Token(Token = "0x400BE05")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400BE06")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform styleExpGauge;
    [Token(Token = "0x400BE07")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject levelUpObj;
    [Token(Token = "0x400BE08")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject styleIcon;
    [Token(Token = "0x400BE09")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject lockIcon;
    [Token(Token = "0x400BE0A")]
    [FieldOffset(Offset = "0x60")]
    private float endExpBarTime;
    [Token(Token = "0x400BE0B")]
    [FieldOffset(Offset = "0x68")]
    private Style styleData;
    [Token(Token = "0x400BE0D")]
    [FieldOffset(Offset = "0x78")]
    private ExpeditionOrganization.ExpeditionOldStyle oldData;
    [Token(Token = "0x400BE0E")]
    [FieldOffset(Offset = "0x80")]
    private bool isLevelUp;
    [Token(Token = "0x400BE0F")]
    [FieldOffset(Offset = "0x81")]
    private bool isLock;
    [Token(Token = "0x400BE10")]
    [FieldOffset(Offset = "0x82")]
    private bool isLevelupEffectInit;
    [Token(Token = "0x400BE11")]
    [FieldOffset(Offset = "0x88")]
    private Action<Style> onLevelUpStyleAction;

    [Token(Token = "0x17003C0E")]
    public int Index
    {
      [Token(Token = "0x60116EE"), Address(RVA = "0x4E24EB0", Offset = "0x4E24EB0", VA = "0x4E24EB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60116EF"), Address(RVA = "0x4E24EB8", Offset = "0x4E24EB8", VA = "0x4E24EB8")] private set
      {
      }
    }

    [Token(Token = "0x60116F0")]
    [Address(RVA = "0x4E24D7C", Offset = "0x4E24D7C", VA = "0x4E24D7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60116F1")]
    [Address(RVA = "0x4E24E28", Offset = "0x4E24E28", VA = "0x4E24E28")]
    public void UpdateView(
      int index,
      Style style,
      ExpeditionOrganization.ExpeditionOldStyle oldData,
      bool isLevelUp,
      bool isLock,
      Action<Style> onLevelUpStyleAction)
    {
    }

    [Token(Token = "0x60116F2")]
    [Address(RVA = "0x4E24E4C", Offset = "0x4E24E4C", VA = "0x4E24E4C")]
    public void ShowLevelUpEffect()
    {
    }

    [Token(Token = "0x60116F3")]
    [Address(RVA = "0x4E24EC0", Offset = "0x4E24EC0", VA = "0x4E24EC0")]
    private void UpdateUnitView()
    {
    }

    [Token(Token = "0x60116F4")]
    [Address(RVA = "0x4E25294", Offset = "0x4E25294", VA = "0x4E25294")]
    private void UnitEmpty()
    {
    }

    [Token(Token = "0x60116F5")]
    [Address(RVA = "0x4E2533C", Offset = "0x4E2533C", VA = "0x4E2533C")]
    private void OnStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x60116F6")]
    [Address(RVA = "0x4E25140", Offset = "0x4E25140", VA = "0x4E25140")]
    private void PlayLevelUpEffect()
    {
    }

    [Token(Token = "0x60116F7")]
    [Address(RVA = "0x4E2522C", Offset = "0x4E2522C", VA = "0x4E2522C")]
    private IEnumerator StyleExpGaugeUpdate() => (IEnumerator) null;

    [Token(Token = "0x60116F8")]
    [Address(RVA = "0x4E2538C", Offset = "0x4E2538C", VA = "0x4E2538C")]
    public ExpeditionStyleExpUnitSlot()
    {
    }
  }
}
