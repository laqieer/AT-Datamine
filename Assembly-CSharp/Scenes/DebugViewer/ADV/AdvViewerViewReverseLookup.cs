// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewReverseLookup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x20030A2")]
  internal class AdvViewerViewReverseLookup : AdvViewerViewBase
  {
    [Token(Token = "0x400CEFB")]
    [FieldOffset(Offset = "0x30")]
    private string filterString;
    [Token(Token = "0x400CEFD")]
    [FieldOffset(Offset = "0x40")]
    public AdvViewerViewReverseLookup.TextGuiDropdown scriptFileNameDropdown;
    [Token(Token = "0x400CEFE")]
    [FieldOffset(Offset = "0x48")]
    public AdvViewerViewReverseLookup.TextGuiDropdown sequenceDropdown;
    [Token(Token = "0x400CEFF")]
    [FieldOffset(Offset = "0x50")]
    public AdvViewerViewReverseLookup.CommunicationParamGuiDropdoun communicationParamGuiDropdoun;
    [Token(Token = "0x400CF00")]
    [FieldOffset(Offset = "0x58")]
    public AdvViewerViewReverseLookup.TextGuiDropdown communicationLocationCharaGuiDropdoun;

    [Token(Token = "0x140001E7")]
    public event Action OnPlayButton
    {
      [Token(Token = "0x601301B"), Address(RVA = "0x43284E4", Offset = "0x43284E4", VA = "0x43284E4")] add
      {
      }
      [Token(Token = "0x601301C"), Address(RVA = "0x4328580", Offset = "0x4328580", VA = "0x4328580")] remove
      {
      }
    }

    [Token(Token = "0x140001E8")]
    public event Action<string> OnChangeFilterString
    {
      [Token(Token = "0x601301D"), Address(RVA = "0x432861C", Offset = "0x432861C", VA = "0x432861C")] add
      {
      }
      [Token(Token = "0x601301E"), Address(RVA = "0x43286CC", Offset = "0x43286CC", VA = "0x43286CC")] remove
      {
      }
    }

    [Token(Token = "0x601301F")]
    [Address(RVA = "0x432877C", Offset = "0x432877C", VA = "0x432877C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6013020")]
    [Address(RVA = "0x43288AC", Offset = "0x43288AC", VA = "0x43288AC", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6013021")]
    [Address(RVA = "0x4328B9C", Offset = "0x4328B9C", VA = "0x4328B9C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6013022")]
    [Address(RVA = "0x4328BBC", Offset = "0x4328BBC", VA = "0x4328BBC")]
    public void SetScriptFileNameList(IEnumerable<string> list)
    {
    }

    [Token(Token = "0x6013023")]
    [Address(RVA = "0x4328DC4", Offset = "0x4328DC4", VA = "0x4328DC4")]
    public void SetSequenceNameList(IEnumerable<string> list)
    {
    }

    [Token(Token = "0x6013024")]
    [Address(RVA = "0x4328E1C", Offset = "0x4328E1C", VA = "0x4328E1C")]
    public void SetCommunicationLocationList(IEnumerable<string> list)
    {
    }

    [Token(Token = "0x6013025")]
    [Address(RVA = "0x4328E74", Offset = "0x4328E74", VA = "0x4328E74")]
    public AdvViewerViewReverseLookup()
    {
    }

    [Token(Token = "0x20030A3")]
    public class CommunicationParamGuiDropdoun : ReverseLookupGUIDropdown
    {
      [Token(Token = "0x6013026")]
      [Address(RVA = "0x4328F7C", Offset = "0x4328F7C", VA = "0x4328F7C", Slot = "4")]
      public override void DoMainWindow()
      {
      }

      [Token(Token = "0x6013027")]
      [Address(RVA = "0x4328F9C", Offset = "0x4328F9C", VA = "0x4328F9C", Slot = "5")]
      public override int OnGui(int windowId, Rect dropdownRect) => new int();

      [Token(Token = "0x6013028")]
      [Address(RVA = "0x4328FD0", Offset = "0x4328FD0", VA = "0x4328FD0", Slot = "6")]
      public override void Initialize()
      {
      }

      [Token(Token = "0x6013029")]
      [Address(RVA = "0x4328F74", Offset = "0x4328F74", VA = "0x4328F74")]
      public CommunicationParamGuiDropdoun()
      {
      }
    }

    [Token(Token = "0x20030A4")]
    public class CommunicationLocationGuiDropdoun : ReverseLookupGUIDropdown
    {
      [Token(Token = "0x601302B")]
      [Address(RVA = "0x4329264", Offset = "0x4329264", VA = "0x4329264", Slot = "4")]
      public override void DoMainWindow()
      {
      }

      [Token(Token = "0x601302C")]
      [Address(RVA = "0x4329284", Offset = "0x4329284", VA = "0x4329284", Slot = "5")]
      public override int OnGui(int windowId, Rect dropdownRect) => new int();

      [Token(Token = "0x601302D")]
      [Address(RVA = "0x43292B8", Offset = "0x43292B8", VA = "0x43292B8", Slot = "6")]
      public override void Initialize()
      {
      }

      [Token(Token = "0x601302E")]
      [Address(RVA = "0x43292BC", Offset = "0x43292BC", VA = "0x43292BC")]
      public CommunicationLocationGuiDropdoun()
      {
      }
    }

    [Token(Token = "0x20030A5")]
    public class TextGuiDropdown : ReverseLookupGUIDropdown
    {
      [Token(Token = "0x601302F")]
      [Address(RVA = "0x43292C4", Offset = "0x43292C4", VA = "0x43292C4", Slot = "4")]
      public override void DoMainWindow()
      {
      }

      [Token(Token = "0x6013030")]
      [Address(RVA = "0x43292DC", Offset = "0x43292DC", VA = "0x43292DC", Slot = "5")]
      public override int OnGui(int windowId, Rect dropdownRect) => new int();

      [Token(Token = "0x6013031")]
      [Address(RVA = "0x4328C14", Offset = "0x4328C14", VA = "0x4328C14")]
      public void SetList(string title, IEnumerable<string> list)
      {
      }

      [Token(Token = "0x6013032")]
      [Address(RVA = "0x4328F6C", Offset = "0x4328F6C", VA = "0x4328F6C")]
      public TextGuiDropdown()
      {
      }
    }
  }
}
