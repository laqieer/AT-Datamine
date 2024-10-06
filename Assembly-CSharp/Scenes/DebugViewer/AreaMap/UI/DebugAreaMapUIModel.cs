// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F40")]
  internal class DebugAreaMapUIModel
  {
    [Token(Token = "0x17003E92")]
    public Rect MainWindowRect
    {
      [Token(Token = "0x6012781"), Address(RVA = "0x211D9F0", Offset = "0x211D9F0", VA = "0x211D9F0")] set
      {
      }
      [Token(Token = "0x6012782"), Address(RVA = "0x211D9FC", Offset = "0x211D9FC", VA = "0x211D9FC")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x17003E93")]
    public FreeMapManager Manager
    {
      [Token(Token = "0x6012783"), Address(RVA = "0x211DA08", Offset = "0x211DA08", VA = "0x211DA08")] get
      {
        return (FreeMapManager) null;
      }
    }

    [Token(Token = "0x17003E94")]
    public DebugAreaMapLoader Loader
    {
      [Token(Token = "0x6012784"), Address(RVA = "0x211DA10", Offset = "0x211DA10", VA = "0x211DA10")] get
      {
        return (DebugAreaMapLoader) null;
      }
    }

    [Token(Token = "0x17003E95")]
    public DebugAreaMapUIModelLoadMap loadMap
    {
      [Token(Token = "0x6012785"), Address(RVA = "0x211DA18", Offset = "0x211DA18", VA = "0x211DA18")] get
      {
        return (DebugAreaMapUIModelLoadMap) null;
      }
    }

    [Token(Token = "0x17003E96")]
    public DebugAreaMapUIModelInstanceCreate InstanceCreate
    {
      [Token(Token = "0x6012786"), Address(RVA = "0x211DA20", Offset = "0x211DA20", VA = "0x211DA20")] get
      {
        return (DebugAreaMapUIModelInstanceCreate) null;
      }
    }

    [Token(Token = "0x17003E97")]
    public DebugAreaMapUIModelLayoutCreate LayoutCreate
    {
      [Token(Token = "0x6012787"), Address(RVA = "0x211DA28", Offset = "0x211DA28", VA = "0x211DA28")] get
      {
        return (DebugAreaMapUIModelLayoutCreate) null;
      }
    }

    [Token(Token = "0x17003E98")]
    public DebugAreaMapUIModelFootSound FootSound
    {
      [Token(Token = "0x6012788"), Address(RVA = "0x211DA30", Offset = "0x211DA30", VA = "0x211DA30")] get
      {
        return (DebugAreaMapUIModelFootSound) null;
      }
    }

    [Token(Token = "0x17003E99")]
    public DebugAreaMapUIModelPlayerSetting PlayerSetting
    {
      [Token(Token = "0x6012789"), Address(RVA = "0x211DA38", Offset = "0x211DA38", VA = "0x211DA38")] get
      {
        return (DebugAreaMapUIModelPlayerSetting) null;
      }
    }

    [Token(Token = "0x17003E9A")]
    public DebugAreaMapUIModelAutoRun AutoRun
    {
      [Token(Token = "0x601278A"), Address(RVA = "0x211DA40", Offset = "0x211DA40", VA = "0x211DA40")] get
      {
        return (DebugAreaMapUIModelAutoRun) null;
      }
    }

    [Token(Token = "0x601278B")]
    [Address(RVA = "0x211768C", Offset = "0x211768C", VA = "0x211768C")]
    public DebugAreaMapUIModel(FreeMapManager manager, DebugAreaMapLoader loader)
    {
    }
  }
}
