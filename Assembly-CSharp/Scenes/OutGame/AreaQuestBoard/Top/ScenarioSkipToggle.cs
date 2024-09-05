// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.ScenarioSkipToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038FD")]
  internal class ScenarioSkipToggle : MonoBehaviour
  {
    [Token(Token = "0x400F922")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton btn;
    [Token(Token = "0x400F923")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject OnObj;
    [Token(Token = "0x400F924")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject OffObj;
    [Token(Token = "0x400F925")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool isOn;
    [Token(Token = "0x400F926")]
    [FieldOffset(Offset = "0x38")]
    public Action<bool> OnClick;

    [Token(Token = "0x6016675")]
    [Address(RVA = "0x20821D4", Offset = "0x20821D4", VA = "0x20821D4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016676")]
    [Address(RVA = "0x2082394", Offset = "0x2082394", VA = "0x2082394")]
    private void onClickInternal()
    {
    }

    [Token(Token = "0x170049AE")]
    public bool IsOn
    {
      [Token(Token = "0x6016677"), Address(RVA = "0x20823B4", Offset = "0x20823B4", VA = "0x20823B4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016678"), Address(RVA = "0x2080CA4", Offset = "0x2080CA4", VA = "0x2080CA4")] set
      {
      }
    }

    [Token(Token = "0x6016679")]
    [Address(RVA = "0x20823BC", Offset = "0x20823BC", VA = "0x20823BC")]
    private void Set(bool value)
    {
    }

    [Token(Token = "0x601667A")]
    [Address(RVA = "0x20822BC", Offset = "0x20822BC", VA = "0x20822BC")]
    private void OnOffObjectActive(bool on)
    {
    }

    [Token(Token = "0x601667B")]
    [Address(RVA = "0x20823D8", Offset = "0x20823D8", VA = "0x20823D8")]
    public ScenarioSkipToggle()
    {
    }
  }
}
