// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.InstanceCreateSettingBreackable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F6B")]
  internal class InstanceCreateSettingBreackable : InstanceCreateSetting
  {
    [Token(Token = "0x140001A4")]
    public event InstanceCreateSettingBreackable.PlayBreak OnPlayBreak
    {
      [Token(Token = "0x601288A"), Address(RVA = "0x2124F3C", Offset = "0x2124F3C", VA = "0x2124F3C")] add
      {
      }
      [Token(Token = "0x601288B"), Address(RVA = "0x2125C2C", Offset = "0x2125C2C", VA = "0x2125C2C")] remove
      {
      }
    }

    [Token(Token = "0x601288C")]
    [Address(RVA = "0x2124E64", Offset = "0x2124E64", VA = "0x2124E64")]
    public InstanceCreateSettingBreackable(int id, List<string> anchors, List<string> models)
    {
    }

    [Token(Token = "0x601288D")]
    [Address(RVA = "0x2125CC8", Offset = "0x2125CC8", VA = "0x2125CC8", Slot = "6")]
    protected override void DrawTypeSetting()
    {
    }

    [Token(Token = "0x2002F6C")]
    public delegate void PlayBreak(int id);
  }
}
