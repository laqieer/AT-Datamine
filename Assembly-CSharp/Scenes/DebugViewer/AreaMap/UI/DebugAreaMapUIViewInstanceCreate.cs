// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewInstanceCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F60")]
  internal class DebugAreaMapUIViewInstanceCreate : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x400CAFC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly List<string> InstanceTypeName;
    [Token(Token = "0x400CAFD")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 scrollViewPosition;
    [Token(Token = "0x400CAFE")]
    [FieldOffset(Offset = "0x30")]
    private List<InstanceCreateSetting> settings;
    [Token(Token = "0x400CAFF")]
    [FieldOffset(Offset = "0x38")]
    private int settingMakeCounter;
    [Token(Token = "0x400CB00")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown typeDropdown;

    [Token(Token = "0x17003EAD")]
    private List<string> anchorList
    {
      [Token(Token = "0x601283D"), Address(RVA = "0x21236B4", Offset = "0x21236B4", VA = "0x21236B4")] set
      {
      }
      [Token(Token = "0x601283E"), Address(RVA = "0x21236BC", Offset = "0x21236BC", VA = "0x21236BC")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17003EAE")]
    private List<string> characterList
    {
      [Token(Token = "0x601283F"), Address(RVA = "0x21236C4", Offset = "0x21236C4", VA = "0x21236C4")] set
      {
      }
      [Token(Token = "0x6012840"), Address(RVA = "0x21236CC", Offset = "0x21236CC", VA = "0x21236CC")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17003EAF")]
    private List<string> rewardList
    {
      [Token(Token = "0x6012841"), Address(RVA = "0x21236D4", Offset = "0x21236D4", VA = "0x21236D4")] set
      {
      }
      [Token(Token = "0x6012842"), Address(RVA = "0x21236DC", Offset = "0x21236DC", VA = "0x21236DC")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1400019D")]
    public event EventHandler OnCopyClipboard
    {
      [Token(Token = "0x6012843"), Address(RVA = "0x211A21C", Offset = "0x211A21C", VA = "0x211A21C")] add
      {
      }
      [Token(Token = "0x6012844"), Address(RVA = "0x21236E4", Offset = "0x21236E4", VA = "0x21236E4")] remove
      {
      }
    }

    [Token(Token = "0x1400019E")]
    public event DebugAreaMapUIViewInstanceCreate.RequestCreate OnRequestCreate
    {
      [Token(Token = "0x6012845"), Address(RVA = "0x2119F84", Offset = "0x2119F84", VA = "0x2119F84")] add
      {
      }
      [Token(Token = "0x6012846"), Address(RVA = "0x2123780", Offset = "0x2123780", VA = "0x2123780")] remove
      {
      }
    }

    [Token(Token = "0x1400019F")]
    public event DebugAreaMapUIViewInstanceCreate.SelectInstance OnRequestDelete
    {
      [Token(Token = "0x6012847"), Address(RVA = "0x211A0E4", Offset = "0x211A0E4", VA = "0x211A0E4")] add
      {
      }
      [Token(Token = "0x6012848"), Address(RVA = "0x212381C", Offset = "0x212381C", VA = "0x212381C")] remove
      {
      }
    }

    [Token(Token = "0x140001A0")]
    public event DebugAreaMapUIViewInstanceCreate.SelectInstance OnSelectHierarchy
    {
      [Token(Token = "0x6012849"), Address(RVA = "0x211A180", Offset = "0x211A180", VA = "0x211A180")] add
      {
      }
      [Token(Token = "0x601284A"), Address(RVA = "0x21238B8", Offset = "0x21238B8", VA = "0x21238B8")] remove
      {
      }
    }

    [Token(Token = "0x140001A1")]
    public event DebugAreaMapUIViewInstanceCreate.SelectInstance OnPlayChestOpen
    {
      [Token(Token = "0x601284B"), Address(RVA = "0x211A2B8", Offset = "0x211A2B8", VA = "0x211A2B8")] add
      {
      }
      [Token(Token = "0x601284C"), Address(RVA = "0x2123954", Offset = "0x2123954", VA = "0x2123954")] remove
      {
      }
    }

    [Token(Token = "0x140001A2")]
    public event DebugAreaMapUIViewInstanceCreate.SelectInstance OnPlayBreak
    {
      [Token(Token = "0x601284D"), Address(RVA = "0x211A354", Offset = "0x211A354", VA = "0x211A354")] add
      {
      }
      [Token(Token = "0x601284E"), Address(RVA = "0x21239F0", Offset = "0x21239F0", VA = "0x21239F0")] remove
      {
      }
    }

    [Token(Token = "0x601284F")]
    [Address(RVA = "0x2119D30", Offset = "0x2119D30", VA = "0x2119D30")]
    public DebugAreaMapUIViewInstanceCreate()
    {
    }

    [Token(Token = "0x6012850")]
    [Address(RVA = "0x2123A8C", Offset = "0x2123A8C", VA = "0x2123A8C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012851")]
    [Address(RVA = "0x2123C6C", Offset = "0x2123C6C", VA = "0x2123C6C", Slot = "13")]
    protected override void DoMainWindow(int windowID)
    {
    }

    [Token(Token = "0x6012852")]
    [Address(RVA = "0x2124ACC", Offset = "0x2124ACC", VA = "0x2124ACC")]
    private void CreateInstance(
      int id,
      InstanceType type,
      int anchorIdx,
      int modelIdx,
      string animation)
    {
    }

    [Token(Token = "0x6012853")]
    [Address(RVA = "0x2124AE8", Offset = "0x2124AE8", VA = "0x2124AE8")]
    private void SelectHierarchy(int id)
    {
    }

    [Token(Token = "0x6012854")]
    [Address(RVA = "0x2124218", Offset = "0x2124218", VA = "0x2124218")]
    private InstanceCreateSetting CreateSetting(InstanceType type) => (InstanceCreateSetting) null;

    [Token(Token = "0x6012855")]
    [Address(RVA = "0x211C228", Offset = "0x211C228", VA = "0x211C228")]
    public void SetAnchorList(List<string> lists)
    {
    }

    [Token(Token = "0x6012856")]
    [Address(RVA = "0x211C3C8", Offset = "0x211C3C8", VA = "0x211C3C8")]
    public void SetCharacterList(List<string> lists)
    {
    }

    [Token(Token = "0x6012857")]
    [Address(RVA = "0x211C4F8", Offset = "0x211C4F8", VA = "0x211C4F8")]
    public void SetRewardList(List<string> lists)
    {
    }

    [Token(Token = "0x6012858")]
    [Address(RVA = "0x2124FD8", Offset = "0x2124FD8", VA = "0x2124FD8")]
    static DebugAreaMapUIViewInstanceCreate()
    {
    }

    [Token(Token = "0x2002F61")]
    public delegate void RequestCreate(
      int id,
      InstanceType type,
      int anchorIdx,
      int modelIdx,
      string animation);

    [Token(Token = "0x2002F62")]
    public delegate void SelectInstance(int id);
  }
}
