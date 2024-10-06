// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewFacility
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
  [Token(Token = "0x200308D")]
  internal class AdvViewerViewFacility : AdvViewerViewBase
  {
    [Token(Token = "0x400CEB1")]
    [FieldOffset(Offset = "0x58")]
    private GUIDropdown facilityADV;
    [Token(Token = "0x400CEB2")]
    [FieldOffset(Offset = "0x60")]
    private GUIDropdown encounters;
    [Token(Token = "0x400CEB3")]
    [FieldOffset(Offset = "0x68")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CEB4")]
    [FieldOffset(Offset = "0x70")]
    private GUIDropdown bookList;
    [Token(Token = "0x400CEB5")]
    [FieldOffset(Offset = "0x78")]
    private GUIDropdown bookCount;
    [Token(Token = "0x400CEB6")]
    [FieldOffset(Offset = "0x80")]
    private GUIToggleLikeButton bookIsFirst;
    [Token(Token = "0x400CEB7")]
    [FieldOffset(Offset = "0x88")]
    private bool canPlay;
    [Token(Token = "0x400CEB8")]
    [FieldOffset(Offset = "0x90")]
    private StoryFacilityAttachData attachData;
    [Token(Token = "0x400CEB9")]
    [FieldOffset(Offset = "0x98")]
    private ChapterItemData selectedBook;

    [Token(Token = "0x140001D7")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012FAB"), Address(RVA = "0x43226B0", Offset = "0x43226B0", VA = "0x43226B0")] add
      {
      }
      [Token(Token = "0x6012FAC"), Address(RVA = "0x432274C", Offset = "0x432274C", VA = "0x432274C")] remove
      {
      }
    }

    [Token(Token = "0x140001D8")]
    public event Action<int> OnChangeAttachSettingID
    {
      [Token(Token = "0x6012FAD"), Address(RVA = "0x43227E8", Offset = "0x43227E8", VA = "0x43227E8")] add
      {
      }
      [Token(Token = "0x6012FAE"), Address(RVA = "0x4322898", Offset = "0x4322898", VA = "0x4322898")] remove
      {
      }
    }

    [Token(Token = "0x140001D9")]
    public event Action<int> OnChangeEncounterID
    {
      [Token(Token = "0x6012FAF"), Address(RVA = "0x4322948", Offset = "0x4322948", VA = "0x4322948")] add
      {
      }
      [Token(Token = "0x6012FB0"), Address(RVA = "0x43229F8", Offset = "0x43229F8", VA = "0x43229F8")] remove
      {
      }
    }

    [Token(Token = "0x140001DA")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6012FB1"), Address(RVA = "0x4322AA8", Offset = "0x4322AA8", VA = "0x4322AA8")] add
      {
      }
      [Token(Token = "0x6012FB2"), Address(RVA = "0x4322B58", Offset = "0x4322B58", VA = "0x4322B58")] remove
      {
      }
    }

    [Token(Token = "0x140001DB")]
    public event Action<bool> OnChangeLottery
    {
      [Token(Token = "0x6012FB3"), Address(RVA = "0x4322C08", Offset = "0x4322C08", VA = "0x4322C08")] add
      {
      }
      [Token(Token = "0x6012FB4"), Address(RVA = "0x4322CB8", Offset = "0x4322CB8", VA = "0x4322CB8")] remove
      {
      }
    }

    [Token(Token = "0x17003FDD")]
    public bool ParamLottery
    {
      [Token(Token = "0x6012FB5"), Address(RVA = "0x4322D68", Offset = "0x4322D68", VA = "0x4322D68")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012FB6"), Address(RVA = "0x4322D70", Offset = "0x4322D70", VA = "0x4322D70")] set
      {
      }
    }

    [Token(Token = "0x6012FB7")]
    [Address(RVA = "0x4322D7C", Offset = "0x4322D7C", VA = "0x4322D7C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012FB8")]
    [Address(RVA = "0x4322EEC", Offset = "0x4322EEC", VA = "0x4322EEC", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012FB9")]
    [Address(RVA = "0x432320C", Offset = "0x432320C", VA = "0x432320C")]
    private void ShowBookDummyParameter()
    {
    }

    [Token(Token = "0x6012FBA")]
    [Address(RVA = "0x43230D4", Offset = "0x43230D4", VA = "0x43230D4")]
    private void ShowParamSimulateLottery()
    {
    }

    [Token(Token = "0x6012FBB")]
    [Address(RVA = "0x4323000", Offset = "0x4323000", VA = "0x4323000")]
    private void ShowPlayButton()
    {
    }

    [Token(Token = "0x6012FBC")]
    [Address(RVA = "0x432351C", Offset = "0x432351C", VA = "0x432351C")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6012FBD")]
    [Address(RVA = "0x43237F8", Offset = "0x43237F8", VA = "0x43237F8")]
    public void SetEncounterList(
      IEnumerable<StoryFacilityEncountBonusDetailData> list)
    {
    }

    [Token(Token = "0x6012FBE")]
    [Address(RVA = "0x4323A84", Offset = "0x4323A84", VA = "0x4323A84")]
    public void SetParamSimulateLottery(bool lottery)
    {
    }

    [Token(Token = "0x6012FBF")]
    [Address(RVA = "0x4323AA8", Offset = "0x4323AA8", VA = "0x4323AA8")]
    public void SetFacilityList(IEnumerable<StoryFacilityAttachData> list)
    {
    }

    [Token(Token = "0x6012FC0")]
    [Address(RVA = "0x4323CF8", Offset = "0x4323CF8", VA = "0x4323CF8")]
    public void ShowReadingBookParameter(int attachID)
    {
    }

    [Token(Token = "0x6012FC1")]
    [Address(RVA = "0x43240C0", Offset = "0x43240C0", VA = "0x43240C0")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x6012FC2")]
    [Address(RVA = "0x43240CC", Offset = "0x43240CC", VA = "0x43240CC")]
    public AdvViewerViewFacility()
    {
    }
  }
}
