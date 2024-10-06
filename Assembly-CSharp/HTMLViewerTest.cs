// Decompiled with JetBrains decompiler
// Type: HTMLViewerTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using HTMLViewer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200022B")]
public class HTMLViewerTest : MonoBehaviour
{
  [Token(Token = "0x4000CEC")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private HTMLView view;
  [Token(Token = "0x4000CED")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private TextAsset[] htmls;
  [Token(Token = "0x4000CEE")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Button menuButton;
  [Token(Token = "0x4000CEF")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private HTMLViewerTest.Selector htmlSelector;
  [Token(Token = "0x4000CF0")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  [HideInInspector]
  private bool showHeader;
  [Token(Token = "0x4000CF1")]
  [FieldOffset(Offset = "0x3C")]
  [HideInInspector]
  [SerializeField]
  private HeaderTypeEnum headerType;
  [Token(Token = "0x4000CF2")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  [HideInInspector]
  private string headerText;

  [Token(Token = "0x6000DBF")]
  [Address(RVA = "0x1C87D60", Offset = "0x1C87D60", VA = "0x1C87D60")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000DC0")]
  [Address(RVA = "0x1C87DFC", Offset = "0x1C87DFC", VA = "0x1C87DFC")]
  private void InitializeSelector()
  {
  }

  [Token(Token = "0x6000DC1")]
  [Address(RVA = "0x1C88290", Offset = "0x1C88290", VA = "0x1C88290")]
  public void OnClickLink(string url)
  {
  }

  [Token(Token = "0x6000DC2")]
  [Address(RVA = "0x1C88328", Offset = "0x1C88328", VA = "0x1C88328")]
  public HTMLViewerTest()
  {
  }

  [Token(Token = "0x200022C")]
  [Serializable]
  private class Selector
  {
    [Token(Token = "0x4000CF3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform rootObject;
    [Token(Token = "0x4000CF4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button template;
    [Token(Token = "0x4000CF5")]
    [FieldOffset(Offset = "0x20")]
    private List<Button> listItems;

    [Token(Token = "0x6000DC5")]
    [Address(RVA = "0x1C87F90", Offset = "0x1C87F90", VA = "0x1C87F90")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6000DC6")]
    [Address(RVA = "0x1C87FBC", Offset = "0x1C87FBC", VA = "0x1C87FBC")]
    public void InitializeItems(List<string> labels, Action<int> onItemClicked)
    {
    }

    [Token(Token = "0x6000DC7")]
    [Address(RVA = "0x1C8854C", Offset = "0x1C8854C", VA = "0x1C8854C")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x6000DC8")]
    [Address(RVA = "0x1C88348", Offset = "0x1C88348", VA = "0x1C88348")]
    public void Show()
    {
    }

    [Token(Token = "0x6000DC9")]
    [Address(RVA = "0x1C88518", Offset = "0x1C88518", VA = "0x1C88518")]
    public void Hide()
    {
    }

    [Token(Token = "0x6000DCA")]
    [Address(RVA = "0x1C8865C", Offset = "0x1C8865C", VA = "0x1C8865C")]
    private int ButtonToIndex(Button button) => new int();

    [Token(Token = "0x6000DCB")]
    [Address(RVA = "0x1C886B4", Offset = "0x1C886B4", VA = "0x1C886B4")]
    public Selector()
    {
    }
  }
}
