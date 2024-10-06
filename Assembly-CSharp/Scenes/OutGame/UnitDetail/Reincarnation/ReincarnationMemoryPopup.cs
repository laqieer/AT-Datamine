// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Reincarnation.ReincarnationMemoryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Reincarnation
{
  [Token(Token = "0x20032E1")]
  public class ReincarnationMemoryPopup : PopupBase
  {
    [Token(Token = "0x400DB7F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400DB80")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject beforeLvTitle;
    [Token(Token = "0x400DB81")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text beforeLv;
    [Token(Token = "0x400DB82")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text afterLv;
    [Token(Token = "0x400DB83")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ParameterGroup beforeParameter;
    [Token(Token = "0x400DB84")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private ParameterGroup afterParameter;
    [Token(Token = "0x400DB85")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject nonParamMemoryObject;
    [Token(Token = "0x400DB86")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject nonLevelMemoryObject;
    [Token(Token = "0x400DB87")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private RectTransform alertParent;
    [Token(Token = "0x400DB88")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton disableMemoryButton;
    [Token(Token = "0x400DB89")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton disableSaveButton;
    [Token(Token = "0x400DB8A")]
    [FieldOffset(Offset = "0xE0")]
    private APIUnitReincarnationRestore unitReincarnationRestoreApi;
    [Token(Token = "0x400DB8B")]
    [FieldOffset(Offset = "0xE8")]
    private APIUnitReincarnationMemorize unitReincarnationMemorizeApi;
    [Token(Token = "0x400DB8C")]
    [FieldOffset(Offset = "0xF0")]
    private bool isConenctApi;
    [Token(Token = "0x400DB8D")]
    [FieldOffset(Offset = "0xF1")]
    private bool isLevelMax;
    [Token(Token = "0x400DB8E")]
    [FieldOffset(Offset = "0xF8")]
    private Style style;
    [Token(Token = "0x400DB8F")]
    [FieldOffset(Offset = "0x100")]
    private int maxStyleLevel;

    [Token(Token = "0x17004315")]
    public Action UpdateUnit
    {
      [Token(Token = "0x6013FD8"), Address(RVA = "0x2347B94", Offset = "0x2347B94", VA = "0x2347B94")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013FD9"), Address(RVA = "0x2347B9C", Offset = "0x2347B9C", VA = "0x2347B9C")] set
      {
      }
    }

    [Token(Token = "0x6013FDA")]
    [Address(RVA = "0x2347BA4", Offset = "0x2347BA4", VA = "0x2347BA4")]
    public void SetData(Style style)
    {
    }

    [Token(Token = "0x6013FDB")]
    [Address(RVA = "0x23484C0", Offset = "0x23484C0", VA = "0x23484C0")]
    private void ViewToMemory()
    {
    }

    [Token(Token = "0x6013FDC")]
    [Address(RVA = "0x234826C", Offset = "0x234826C", VA = "0x234826C")]
    private int MemoryLevel(int memoryExp, int initRarityStar) => new int();

    [Token(Token = "0x6013FDD")]
    [Address(RVA = "0x234850C", Offset = "0x234850C", VA = "0x234850C")]
    public void OnClickToSave()
    {
    }

    [Token(Token = "0x6013FDE")]
    [Address(RVA = "0x23485A4", Offset = "0x23485A4", VA = "0x23485A4")]
    public void OnClickToMemoryReincarnation()
    {
    }

    [Token(Token = "0x6013FDF")]
    [Address(RVA = "0x234862C", Offset = "0x234862C", VA = "0x234862C")]
    public void OnClickToDisableMemory()
    {
    }

    [Token(Token = "0x6013FE0")]
    [Address(RVA = "0x2348708", Offset = "0x2348708", VA = "0x2348708")]
    public void OnClickToDisableSave()
    {
    }

    [Token(Token = "0x6013FE1")]
    [Address(RVA = "0x2348370", Offset = "0x2348370", VA = "0x2348370")]
    private bool MemoryCheck() => new bool();

    [Token(Token = "0x6013FE2")]
    [Address(RVA = "0x234853C", Offset = "0x234853C", VA = "0x234853C")]
    private IEnumerator ReincarnationSave() => (IEnumerator) null;

    [Token(Token = "0x6013FE3")]
    [Address(RVA = "0x23485C4", Offset = "0x23485C4", VA = "0x23485C4")]
    private IEnumerator ConnectToReincarnationMemory() => (IEnumerator) null;

    [Token(Token = "0x6013FE4")]
    [Address(RVA = "0x2348880", Offset = "0x2348880", VA = "0x2348880")]
    public ReincarnationMemoryPopup()
    {
    }
  }
}
