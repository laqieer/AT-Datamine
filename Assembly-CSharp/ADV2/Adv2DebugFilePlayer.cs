// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2DebugFilePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Lua;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DF7")]
  public class Adv2DebugFilePlayer : Adv2LuaPlayer
  {
    [Token(Token = "0x4010F8E")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<string, string> UiPaths;
    [Token(Token = "0x4010F8F")]
    [FieldOffset(Offset = "0x58")]
    public Dictionary<string, string> AnimationListPaths;
    [Token(Token = "0x4010F90")]
    [FieldOffset(Offset = "0x60")]
    public Dictionary<string, string> FacialListPaths;
    [Token(Token = "0x4010F91")]
    [FieldOffset(Offset = "0x68")]
    public bool isBusy;
    [Token(Token = "0x4010F92")]
    [FieldOffset(Offset = "0x6C")]
    private Rect windowRect;
    [Token(Token = "0x4010F93")]
    [FieldOffset(Offset = "0x80")]
    private GUIStyle customBgStyle;
    [Token(Token = "0x4010F94")]
    [FieldOffset(Offset = "0x88")]
    private GUIStyle customLabelStyle;
    [Token(Token = "0x4010F95")]
    [FieldOffset(Offset = "0x90")]
    private bool layoutflag;

    [Token(Token = "0x17005111")]
    protected GUIStyle CustomBgStyle
    {
      [Token(Token = "0x6018EA2"), Address(RVA = "0x2CAA09C", Offset = "0x2CAA09C", VA = "0x2CAA09C")] get
      {
        return (GUIStyle) null;
      }
    }

    [Token(Token = "0x17005112")]
    protected GUIStyle CustomLabelStyle
    {
      [Token(Token = "0x6018EA3"), Address(RVA = "0x2CAA2D0", Offset = "0x2CAA2D0", VA = "0x2CAA2D0")] get
      {
        return (GUIStyle) null;
      }
    }

    [Token(Token = "0x6018EA4")]
    [Address(RVA = "0x2CAA3F4", Offset = "0x2CAA3F4", VA = "0x2CAA3F4")]
    public IEnumerator SetFile(LuaScriptableObject luaFile) => (IEnumerator) null;

    [Token(Token = "0x6018EA5")]
    [Address(RVA = "0x2CAA490", Offset = "0x2CAA490", VA = "0x2CAA490", Slot = "4")]
    public override void Clear()
    {
    }

    [Token(Token = "0x6018EA6")]
    [Address(RVA = "0x2CAA544", Offset = "0x2CAA544", VA = "0x2CAA544")]
    private void showCameraInfo(int windowid)
    {
    }

    [Token(Token = "0x6018EA7")]
    [Address(RVA = "0x2CAAD0C", Offset = "0x2CAAD0C", VA = "0x2CAAD0C")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6018EA8")]
    [Address(RVA = "0x2CAAFB8", Offset = "0x2CAAFB8", VA = "0x2CAAFB8")]
    public Adv2DebugFilePlayer()
    {
    }
  }
}
