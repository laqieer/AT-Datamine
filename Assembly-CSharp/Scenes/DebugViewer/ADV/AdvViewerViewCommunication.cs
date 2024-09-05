// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewCommunication
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003083")]
  internal class AdvViewerViewCommunication : AdvViewerViewBase
  {
    [Token(Token = "0x400CE87")]
    [FieldOffset(Offset = "0x68")]
    private GUIDropdown paramList;
    [Token(Token = "0x400CE88")]
    [FieldOffset(Offset = "0x70")]
    private GUIDropdown communication;
    [Token(Token = "0x400CE89")]
    [FieldOffset(Offset = "0x78")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CE8A")]
    [FieldOffset(Offset = "0x80")]
    private string scriptFileName;
    [Token(Token = "0x400CE8B")]
    [FieldOffset(Offset = "0x88")]
    private bool isTargetRankup;
    [Token(Token = "0x400CE8C")]
    [FieldOffset(Offset = "0x89")]
    private bool enable;

    [Token(Token = "0x140001C6")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012F65"), Address(RVA = "0x431E8CC", Offset = "0x431E8CC", VA = "0x431E8CC")] add
      {
      }
      [Token(Token = "0x6012F66"), Address(RVA = "0x431E968", Offset = "0x431E968", VA = "0x431E968")] remove
      {
      }
    }

    [Token(Token = "0x140001C7")]
    public event Action<int> OnChangeCommuIdentifier
    {
      [Token(Token = "0x6012F67"), Address(RVA = "0x431EA04", Offset = "0x431EA04", VA = "0x431EA04")] add
      {
      }
      [Token(Token = "0x6012F68"), Address(RVA = "0x431EAB4", Offset = "0x431EAB4", VA = "0x431EAB4")] remove
      {
      }
    }

    [Token(Token = "0x140001C8")]
    public event Action<string> OnChangeScritpFileName
    {
      [Token(Token = "0x6012F69"), Address(RVA = "0x431EB64", Offset = "0x431EB64", VA = "0x431EB64")] add
      {
      }
      [Token(Token = "0x6012F6A"), Address(RVA = "0x431EC14", Offset = "0x431EC14", VA = "0x431EC14")] remove
      {
      }
    }

    [Token(Token = "0x140001C9")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6012F6B"), Address(RVA = "0x431ECC4", Offset = "0x431ECC4", VA = "0x431ECC4")] add
      {
      }
      [Token(Token = "0x6012F6C"), Address(RVA = "0x431ED74", Offset = "0x431ED74", VA = "0x431ED74")] remove
      {
      }
    }

    [Token(Token = "0x140001CA")]
    public event Action<bool> OnChangeIsTargetRankup
    {
      [Token(Token = "0x6012F6D"), Address(RVA = "0x431EE24", Offset = "0x431EE24", VA = "0x431EE24")] add
      {
      }
      [Token(Token = "0x6012F6E"), Address(RVA = "0x431EED4", Offset = "0x431EED4", VA = "0x431EED4")] remove
      {
      }
    }

    [Token(Token = "0x140001CB")]
    public event Action<int> OnChangeCommuParamId
    {
      [Token(Token = "0x6012F6F"), Address(RVA = "0x431EF84", Offset = "0x431EF84", VA = "0x431EF84")] add
      {
      }
      [Token(Token = "0x6012F70"), Address(RVA = "0x431F034", Offset = "0x431F034", VA = "0x431F034")] remove
      {
      }
    }

    [Token(Token = "0x140001CC")]
    public event Action OnChangeHumanRankMax
    {
      [Token(Token = "0x6012F71"), Address(RVA = "0x431F0E4", Offset = "0x431F0E4", VA = "0x431F0E4")] add
      {
      }
      [Token(Token = "0x6012F72"), Address(RVA = "0x431F180", Offset = "0x431F180", VA = "0x431F180")] remove
      {
      }
    }

    [Token(Token = "0x140001CD")]
    public event Action OnChangeHumanRankReset
    {
      [Token(Token = "0x6012F73"), Address(RVA = "0x431F21C", Offset = "0x431F21C", VA = "0x431F21C")] add
      {
      }
      [Token(Token = "0x6012F74"), Address(RVA = "0x431F2B8", Offset = "0x431F2B8", VA = "0x431F2B8")] remove
      {
      }
    }

    [Token(Token = "0x6012F75")]
    [Address(RVA = "0x431F354", Offset = "0x431F354", VA = "0x431F354", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012F76")]
    [Address(RVA = "0x431F474", Offset = "0x431F474", VA = "0x431F474", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012F77")]
    [Address(RVA = "0x431F994", Offset = "0x431F994", VA = "0x431F994")]
    public void SetCommunicationList(IEnumerable<StoryCommunicationIdentifierData> list)
    {
    }

    [Token(Token = "0x6012F78")]
    [Address(RVA = "0x431FBE4", Offset = "0x431FBE4", VA = "0x431FBE4")]
    public void SetCommunicationParamList(IEnumerable<StoryCommunicationParamData> list)
    {
    }

    [Token(Token = "0x6012F79")]
    [Address(RVA = "0x431FDD4", Offset = "0x431FDD4", VA = "0x431FDD4")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6012F7A")]
    [Address(RVA = "0x43200B0", Offset = "0x43200B0", VA = "0x43200B0")]
    public void SetChangeEnable(bool enable)
    {
    }

    [Token(Token = "0x6012F7B")]
    [Address(RVA = "0x43200BC", Offset = "0x43200BC", VA = "0x43200BC")]
    public void SstIsTargetRankup(bool rankup)
    {
    }

    [Token(Token = "0x6012F7C")]
    [Address(RVA = "0x43200C8", Offset = "0x43200C8", VA = "0x43200C8")]
    public AdvViewerViewCommunication()
    {
    }
  }
}
