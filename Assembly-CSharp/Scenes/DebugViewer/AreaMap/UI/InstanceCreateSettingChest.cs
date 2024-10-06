// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.InstanceCreateSettingChest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F68")]
  internal class InstanceCreateSettingChest : InstanceCreateSetting
  {
    [Token(Token = "0x140001A3")]
    public event InstanceCreateSettingChest.PlayOpen OnPlayOpen
    {
      [Token(Token = "0x601287E"), Address(RVA = "0x2124DC8", Offset = "0x2124DC8", VA = "0x2124DC8")] add
      {
      }
      [Token(Token = "0x601287F"), Address(RVA = "0x21258BC", Offset = "0x21258BC", VA = "0x21258BC")] remove
      {
      }
    }

    [Token(Token = "0x6012880")]
    [Address(RVA = "0x2124CF0", Offset = "0x2124CF0", VA = "0x2124CF0")]
    public InstanceCreateSettingChest(int id, List<string> anchors, List<string> models)
    {
    }

    [Token(Token = "0x6012881")]
    [Address(RVA = "0x2125958", Offset = "0x2125958", VA = "0x2125958", Slot = "6")]
    protected override void DrawTypeSetting()
    {
    }

    [Token(Token = "0x2002F69")]
    public delegate void PlayOpen(int id);

    [Token(Token = "0x2002F6A")]
    public delegate void PlayClose(int id);
  }
}
