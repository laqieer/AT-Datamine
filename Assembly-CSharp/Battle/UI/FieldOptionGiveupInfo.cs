// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionGiveupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.Input;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002316")]
  public class FieldOptionGiveupInfo : MonoBehaviour
  {
    [Token(Token = "0x400947C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400947D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400947E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text questNameText;
    [Token(Token = "0x400947F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform getItemTrans;
    [Token(Token = "0x4009480")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button giveupButton;
    [Token(Token = "0x4009481")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI goldDropText;
    [Token(Token = "0x4009482")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI silverDropText;
    [Token(Token = "0x4009483")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI bronzeDropText;
    [Token(Token = "0x4009484")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject difficultyObj;
    [Token(Token = "0x4009485")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject difficultyHardObj;
    [Token(Token = "0x4009486")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject difficultyVeryHardObj;
    [Token(Token = "0x4009487")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009488")]
    [FieldOffset(Offset = "0x78")]
    private bool showFlag;
    [Token(Token = "0x4009489")]
    [FieldOffset(Offset = "0x80")]
    private UnityAction endCallback;

    [Token(Token = "0x17002E3D")]
    public UnityAction CloseButtonEvent
    {
      [Token(Token = "0x600D65B"), Address(RVA = "0x1D1DC4C", Offset = "0x1D1DC4C", VA = "0x1D1DC4C")] set
      {
      }
    }

    [Token(Token = "0x17002E3E")]
    public UnityAction GiveupButtonEvent
    {
      [Token(Token = "0x600D65C"), Address(RVA = "0x1D1DC70", Offset = "0x1D1DC70", VA = "0x1D1DC70")] set
      {
      }
    }

    [Token(Token = "0x600D65D")]
    [Address(RVA = "0x1D1DC94", Offset = "0x1D1DC94", VA = "0x1D1DC94")]
    public IEnumerator InitializeCoroutine(
      StoryBattleConfig config,
      GameObject itemPrefab,
      BoardData board,
      UnityAction callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D65E")]
    [Address(RVA = "0x1D1DD44", Offset = "0x1D1DD44", VA = "0x1D1DD44")]
    private void SetUpDropItem(IReadOnlyDictionary<int, int> dropItems)
    {
    }

    [Token(Token = "0x600D65F")]
    [Address(RVA = "0x1D1DF74", Offset = "0x1D1DF74", VA = "0x1D1DF74")]
    public void Show()
    {
    }

    [Token(Token = "0x600D660")]
    [Address(RVA = "0x1D1E018", Offset = "0x1D1E018", VA = "0x1D1E018")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D661")]
    [Address(RVA = "0x1D1E0C0", Offset = "0x1D1E0C0", VA = "0x1D1E0C0")]
    public void Giveup()
    {
    }

    [Token(Token = "0x600D662")]
    [Address(RVA = "0x1D1E0F8", Offset = "0x1D1E0F8", VA = "0x1D1E0F8")]
    public IEnumerator PopupDelete() => (IEnumerator) null;

    [Token(Token = "0x600D663")]
    [Address(RVA = "0x1D1E188", Offset = "0x1D1E188", VA = "0x1D1E188")]
    public FieldOptionGiveupInfo()
    {
    }
  }
}
