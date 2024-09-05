// Decompiled with JetBrains decompiler
// Type: LoginBonus.Debug.DebugLoginBonusSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace LoginBonus.Debug
{
  [Token(Token = "0x2000B0C")]
  public class DebugLoginBonusSubScene : SubScene
  {
    [Token(Token = "0x4003271")]
    [FieldOffset(Offset = "0x58")]
    private LoginBonusSequencePlayer loginBonusSequencePlayer;
    [Token(Token = "0x4003272")]
    [FieldOffset(Offset = "0x60")]
    private IReadOnlyList<LoginBonusData> loginBonusData;
    [Token(Token = "0x4003273")]
    [FieldOffset(Offset = "0x68")]
    private int loginCount;
    [Token(Token = "0x4003274")]
    [FieldOffset(Offset = "0x6C")]
    private int totalLoginCount;
    [Token(Token = "0x4003275")]
    [FieldOffset(Offset = "0x70")]
    private int selectedIndex;
    [Token(Token = "0x4003276")]
    [FieldOffset(Offset = "0x78")]
    private DebugLoginBonusSubScene.GUIMainWindow mainWindow;
    [Token(Token = "0x4003277")]
    [FieldOffset(Offset = "0x80")]
    private IGUIWindow subWindow;
    [Token(Token = "0x4003278")]
    [FieldOffset(Offset = "0x88")]
    private GUIResolutionAdjuster resolutionAdjuster;
    [Token(Token = "0x4003279")]
    [FieldOffset(Offset = "0x90")]
    private DebugLoginBonusSubScene.IDGenerator iDGenerator;
    [Token(Token = "0x400327A")]
    [FieldOffset(Offset = "0x98")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17000922")]
    private LoginBonusData selectedLoginBonus
    {
      [Token(Token = "0x6003EE2"), Address(RVA = "0x2C179B0", Offset = "0x2C179B0", VA = "0x2C179B0")] get
      {
        return (LoginBonusData) null;
      }
    }

    [Token(Token = "0x6003EE3")]
    [Address(RVA = "0x2C17A58", Offset = "0x2C17A58", VA = "0x2C17A58", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003EE4")]
    [Address(RVA = "0x2C17AE8", Offset = "0x2C17AE8", VA = "0x2C17AE8")]
    private void InitializeLoginBonusData()
    {
    }

    [Token(Token = "0x6003EE5")]
    [Address(RVA = "0x2C17C00", Offset = "0x2C17C00", VA = "0x2C17C00")]
    private void InitializeGUI()
    {
    }

    [Token(Token = "0x6003EE6")]
    [Address(RVA = "0x2C1807C", Offset = "0x2C1807C", VA = "0x2C1807C", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003EE7")]
    [Address(RVA = "0x2C17FF8", Offset = "0x2C17FF8", VA = "0x2C17FF8")]
    private Rect GetMainWindowPosition() => new Rect();

    [Token(Token = "0x6003EE8")]
    [Address(RVA = "0x2C18104", Offset = "0x2C18104", VA = "0x2C18104")]
    private Rect GetSubWindowPosition() => new Rect();

    [Token(Token = "0x6003EE9")]
    [Address(RVA = "0x2C181A0", Offset = "0x2C181A0", VA = "0x2C181A0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003EEA")]
    [Address(RVA = "0x2C181D4", Offset = "0x2C181D4", VA = "0x2C181D4")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6003EEB")]
    [Address(RVA = "0x2C184D0", Offset = "0x2C184D0", VA = "0x2C184D0")]
    private void OnClickLoginBonusChangeButton()
    {
    }

    [Token(Token = "0x6003EEC")]
    [Address(RVA = "0x2C18930", Offset = "0x2C18930", VA = "0x2C18930")]
    private bool IsEnabledLoginBonusData() => new bool();

    [Token(Token = "0x6003EED")]
    [Address(RVA = "0x2C18938", Offset = "0x2C18938", VA = "0x2C18938")]
    private bool IsEnabledLoginBonusData(int index) => new bool();

    [Token(Token = "0x6003EEE")]
    [Address(RVA = "0x2C18678", Offset = "0x2C18678", VA = "0x2C18678")]
    private List<string> GetLoginBonusNameList() => (List<string>) null;

    [Token(Token = "0x6003EEF")]
    [Address(RVA = "0x2C189F4", Offset = "0x2C189F4", VA = "0x2C189F4")]
    private void OnClickPlayButton()
    {
    }

    [Token(Token = "0x6003EF0")]
    [Address(RVA = "0x2C18B64", Offset = "0x2C18B64", VA = "0x2C18B64")]
    private void SetLoginBonusByIndex(int index)
    {
    }

    [Token(Token = "0x6003EF1")]
    [Address(RVA = "0x2C18EDC", Offset = "0x2C18EDC", VA = "0x2C18EDC")]
    private void SetLoginCount(int loginCount, int minLoginCount, int maxLoginCount)
    {
    }

    [Token(Token = "0x6003EF2")]
    [Address(RVA = "0x2C18FA0", Offset = "0x2C18FA0", VA = "0x2C18FA0")]
    private void SetTotalLoginCount(int totalLoginCount, int minLoginCount, int maxLoginCount)
    {
    }

    [Token(Token = "0x6003EF3")]
    [Address(RVA = "0x2C18A58", Offset = "0x2C18A58", VA = "0x2C18A58")]
    private void PlayLoginBonus(
      int loginBonusId,
      LoginBonusTypeEnum loginBonusType,
      int loginCount,
      int totalLoginCount)
    {
    }

    [Token(Token = "0x6003EF4")]
    [Address(RVA = "0x2C192C0", Offset = "0x2C192C0", VA = "0x2C192C0")]
    private void PlayAlwaysLoginBonus(int loginBonusId, int loginCount, int totalLoginCount)
    {
    }

    [Token(Token = "0x6003EF5")]
    [Address(RVA = "0x2C19368", Offset = "0x2C19368", VA = "0x2C19368")]
    private void PlayBeginnerLoginBonus(int loginBonusId, int loginCount, int totalLoginCount)
    {
    }

    [Token(Token = "0x6003EF6")]
    [Address(RVA = "0x2C18AAC", Offset = "0x2C18AAC", VA = "0x2C18AAC")]
    private void PlayLoginBonusNoMasterData()
    {
    }

    [Token(Token = "0x6003EF7")]
    [Address(RVA = "0x2C19420", Offset = "0x2C19420", VA = "0x2C19420")]
    public DebugLoginBonusSubScene()
    {
    }

    [Token(Token = "0x2000B0D")]
    private class GUIMainWindow : GUIWindow
    {
      [Token(Token = "0x400327B")]
      [FieldOffset(Offset = "0x30")]
      private GUISelectableLabel loginBonusName;
      [Token(Token = "0x400327C")]
      [FieldOffset(Offset = "0x38")]
      private ILoginCountSelector loginCountSelector;
      [Token(Token = "0x400327D")]
      [FieldOffset(Offset = "0x40")]
      private ILoginCountSelector totalLoginCountSelector;
      [Token(Token = "0x4003280")]
      [FieldOffset(Offset = "0x58")]
      private Vector2 scrollPos;

      [Token(Token = "0x140000EE")]
      public event Action OnClickLoginBonusChange
      {
        [Token(Token = "0x6003EFC"), Address(RVA = "0x2C17EC0", Offset = "0x2C17EC0", VA = "0x2C17EC0")] add
        {
        }
        [Token(Token = "0x6003EFD"), Address(RVA = "0x2C19494", Offset = "0x2C19494", VA = "0x2C19494")] remove
        {
        }
      }

      [Token(Token = "0x140000EF")]
      public event Action OnClickPlay
      {
        [Token(Token = "0x6003EFE"), Address(RVA = "0x2C17F5C", Offset = "0x2C17F5C", VA = "0x2C17F5C")] add
        {
        }
        [Token(Token = "0x6003EFF"), Address(RVA = "0x2C19530", Offset = "0x2C19530", VA = "0x2C19530")] remove
        {
        }
      }

      [Token(Token = "0x6003F00")]
      [Address(RVA = "0x2C17DBC", Offset = "0x2C17DBC", VA = "0x2C17DBC")]
      public GUIMainWindow(int id, string windowTitle)
      {
      }

      [Token(Token = "0x6003F01")]
      [Address(RVA = "0x2C19064", Offset = "0x2C19064", VA = "0x2C19064")]
      public void SetLoginBonusName(string loginBonusName)
      {
      }

      [Token(Token = "0x6003F02")]
      [Address(RVA = "0x2C19080", Offset = "0x2C19080", VA = "0x2C19080")]
      public void SetLoginCount(
        int loginCount,
        int minLoginCount,
        int maxLoginCount,
        Action<int> onLoginCountChanged)
      {
      }

      [Token(Token = "0x6003F03")]
      [Address(RVA = "0x2C191A0", Offset = "0x2C191A0", VA = "0x2C191A0")]
      public void SetTotalLoginCount(
        int totalLoginCount,
        int minLoginCount,
        int maxLoginCount,
        Action<int> onTotalLoginCountChanged)
      {
      }

      [Token(Token = "0x6003F04")]
      [Address(RVA = "0x2C1969C", Offset = "0x2C1969C", VA = "0x2C1969C", Slot = "8")]
      public override void OnGUI(int id)
      {
      }
    }

    [Token(Token = "0x2000B10")]
    private class GUIListSelectWindow : GUIWindow
    {
      [Token(Token = "0x4003283")]
      [FieldOffset(Offset = "0x30")]
      private GUIListSelector listSelector;

      [Token(Token = "0x6003F0A")]
      [Address(RVA = "0x2C18884", Offset = "0x2C18884", VA = "0x2C18884")]
      public GUIListSelectWindow(
        int id,
        string windowTitle,
        IReadOnlyList<string> listItems,
        int defaultSelect,
        Action<int> onSelect)
      {
      }

      [Token(Token = "0x6003F0B")]
      [Address(RVA = "0x2C19E7C", Offset = "0x2C19E7C", VA = "0x2C19E7C", Slot = "8")]
      public override void OnGUI(int id)
      {
      }
    }

    [Token(Token = "0x2000B11")]
    private class GUILoginCountSelector : ILoginCountSelector
    {
      [Token(Token = "0x4003284")]
      [FieldOffset(Offset = "0x10")]
      private readonly int minLoginCount;
      [Token(Token = "0x4003285")]
      [FieldOffset(Offset = "0x14")]
      private readonly int maxLoginCount;
      [Token(Token = "0x4003286")]
      [FieldOffset(Offset = "0x18")]
      private readonly string title;
      [Token(Token = "0x4003287")]
      [FieldOffset(Offset = "0x20")]
      private int loginCount;
      [Token(Token = "0x4003288")]
      [FieldOffset(Offset = "0x28")]
      private Action<int> onLoginCountChanged;

      [Token(Token = "0x6003F0C")]
      [Address(RVA = "0x2C19640", Offset = "0x2C19640", VA = "0x2C19640")]
      public GUILoginCountSelector(
        string title,
        int defaultLoginCount,
        int minLoginCount,
        int maxLoginCount,
        Action<int> onLoginCountChanged)
      {
      }

      [Token(Token = "0x6003F0D")]
      [Address(RVA = "0x2C1A1BC", Offset = "0x2C1A1BC", VA = "0x2C1A1BC", Slot = "4")]
      public void OnGUI()
      {
      }
    }

    [Token(Token = "0x2000B12")]
    private class IDGenerator
    {
      [Token(Token = "0x4003289")]
      [FieldOffset(Offset = "0x10")]
      private int id;

      [Token(Token = "0x6003F0E")]
      [Address(RVA = "0x2C17DA8", Offset = "0x2C17DA8", VA = "0x2C17DA8")]
      public int GenerateID() => new int();

      [Token(Token = "0x6003F0F")]
      [Address(RVA = "0x2C1A5E0", Offset = "0x2C1A5E0", VA = "0x2C1A5E0")]
      public IDGenerator()
      {
      }
    }
  }
}
