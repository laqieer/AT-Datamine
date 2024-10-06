// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.InstanceCreateSettingNpc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F67")]
  internal class InstanceCreateSettingNpc : InstanceCreateSetting
  {
    [Token(Token = "0x400CB12")]
    [FieldOffset(Offset = "0x30")]
    private GUIDropdown animation;
    [Token(Token = "0x400CB13")]
    [FieldOffset(Offset = "0x38")]
    private readonly List<string> AnimationList;

    [Token(Token = "0x17003EB5")]
    public override string AnimationName
    {
      [Token(Token = "0x601287A"), Address(RVA = "0x21257CC", Offset = "0x21257CC", VA = "0x21257CC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601287B")]
    [Address(RVA = "0x2124B04", Offset = "0x2124B04", VA = "0x2124B04")]
    public InstanceCreateSettingNpc(int id, List<string> anchors, List<string> models)
    {
    }

    [Token(Token = "0x601287C")]
    [Address(RVA = "0x2125838", Offset = "0x2125838", VA = "0x2125838", Slot = "6")]
    protected override void DrawTypeSetting()
    {
    }

    [Token(Token = "0x601287D")]
    [Address(RVA = "0x2125858", Offset = "0x2125858", VA = "0x2125858", Slot = "5")]
    public override void ShowWindow(Rect rect)
    {
    }
  }
}
