// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Option;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000BA6")]
  public class GlobalMenuOptionView : MonoBehaviour
  {
    [Token(Token = "0x400351B")]
    [FieldOffset(Offset = "0x18")]
    private Func<string> RETURN_TITLE;
    [Token(Token = "0x400351C")]
    [FieldOffset(Offset = "0x20")]
    private Func<string> CANCEL_BUTTON_NAME;
    [Token(Token = "0x400351D")]
    [FieldOffset(Offset = "0x28")]
    private Func<string> RETURN_TITLE_BUTTON_NAME;
    [Token(Token = "0x400351E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400351F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI currencyPaidText;
    [Token(Token = "0x4003520")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI currencyFreeText;
    [Token(Token = "0x4003521")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GlobalMenuOption option;
    [Token(Token = "0x4003522")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ContainerLegalsMenu containerLegalsMenu;
    [Token(Token = "0x4003523")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ContainerSupportMenu containerSupportMenu;
    [Token(Token = "0x4003524")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private DataLinkageRegisterView dataLinkageMenu;
    [Token(Token = "0x4003525")]
    [FieldOffset(Offset = "0x68")]
    private GlobalMenuOptionSetting.OptionMenu currentContens;
    [Token(Token = "0x4003526")]
    [FieldOffset(Offset = "0x70")]
    private Dictionary<GlobalMenuOptionSetting.OptionMenu, string> inAnimeDatas;
    [Token(Token = "0x4003527")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<GlobalMenuOptionSetting.OptionMenu, string> outAnimeDatas;

    [Token(Token = "0x600427E")]
    [Address(RVA = "0x3639E4C", Offset = "0x3639E4C", VA = "0x3639E4C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600427F")]
    [Address(RVA = "0x3639EAC", Offset = "0x3639EAC", VA = "0x3639EAC")]
    public void ChangeContens(GlobalMenuOptionSetting.OptionMenu optionMenu, bool isInit = false)
    {
    }

    [Token(Token = "0x6004280")]
    [Address(RVA = "0x363A020", Offset = "0x363A020", VA = "0x363A020")]
    private void PlayInOutAnim(GlobalMenuOptionSetting.OptionMenu oldMenuType)
    {
    }

    [Token(Token = "0x6004281")]
    [Address(RVA = "0x363A218", Offset = "0x363A218", VA = "0x363A218")]
    public void OnTitleButton()
    {
    }

    [Token(Token = "0x6004282")]
    [Address(RVA = "0x363A590", Offset = "0x363A590", VA = "0x363A590")]
    public GlobalMenuOptionView()
    {
    }
  }
}
