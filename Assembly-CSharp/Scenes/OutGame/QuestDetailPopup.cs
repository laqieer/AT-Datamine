// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200322E")]
  public class QuestDetailPopup : PopupBase
  {
    [Token(Token = "0x400D65A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400D65B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonToggle basicToggle;
    [Token(Token = "0x400D65C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonToggle captureToggle;
    [Token(Token = "0x400D65D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonToggle sortieRestrictToggle;
    [Token(Token = "0x400D65E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private QuestDetailBasicInfo basicInfo;
    [Token(Token = "0x400D65F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private QuestDetailCaptureInfo captureInfo;
    [Token(Token = "0x400D660")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private QuestDetailSortieRestrict sortieRestrict;
    [Token(Token = "0x400D661")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400D662")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D663")]
    [FieldOffset(Offset = "0xD0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6013920")]
    [Address(RVA = "0x460B46C", Offset = "0x460B46C", VA = "0x460B46C")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner, QuestInfo questInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013921")]
    [Address(RVA = "0x460B510", Offset = "0x460B510", VA = "0x460B510")]
    private void ToggleInitialize(bool sortieDisplay)
    {
    }

    [Token(Token = "0x6013922")]
    [Address(RVA = "0x460B724", Offset = "0x460B724", VA = "0x460B724")]
    private void SwitchShowInfo(QuestDetailPopup.ShowMode mode)
    {
    }

    [Token(Token = "0x6013923")]
    [Address(RVA = "0x460B7AC", Offset = "0x460B7AC", VA = "0x460B7AC")]
    public QuestDetailPopup()
    {
    }

    [Token(Token = "0x200322F")]
    private enum ShowMode
    {
      [Token(Token = "0x400D665")] Basic,
      [Token(Token = "0x400D666")] Capture,
      [Token(Token = "0x400D667")] SortieRestrict,
    }
  }
}
