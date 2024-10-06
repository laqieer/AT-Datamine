// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewSampleAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x20030A7")]
  internal class AdvViewerViewSampleAdv : AdvViewerViewBase
  {
    [Token(Token = "0x400CF06")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown fileNameList;
    [Token(Token = "0x400CF07")]
    [FieldOffset(Offset = "0x48")]
    private string scriptFileName;

    [Token(Token = "0x140001E9")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6013035"), Address(RVA = "0x43293D8", Offset = "0x43293D8", VA = "0x43293D8")] add
      {
      }
      [Token(Token = "0x6013036"), Address(RVA = "0x4329474", Offset = "0x4329474", VA = "0x4329474")] remove
      {
      }
    }

    [Token(Token = "0x140001EA")]
    public event Action<string> OnChangeFileName
    {
      [Token(Token = "0x6013037"), Address(RVA = "0x4329510", Offset = "0x4329510", VA = "0x4329510")] add
      {
      }
      [Token(Token = "0x6013038"), Address(RVA = "0x43295C0", Offset = "0x43295C0", VA = "0x43295C0")] remove
      {
      }
    }

    [Token(Token = "0x140001EB")]
    public event Action<string> OnChangeScritpFileName
    {
      [Token(Token = "0x6013039"), Address(RVA = "0x4329670", Offset = "0x4329670", VA = "0x4329670")] add
      {
      }
      [Token(Token = "0x601303A"), Address(RVA = "0x4329720", Offset = "0x4329720", VA = "0x4329720")] remove
      {
      }
    }

    [Token(Token = "0x601303B")]
    [Address(RVA = "0x43297D0", Offset = "0x43297D0", VA = "0x43297D0", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x601303C")]
    [Address(RVA = "0x4329868", Offset = "0x4329868", VA = "0x4329868", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x601303D")]
    [Address(RVA = "0x4329B2C", Offset = "0x4329B2C", VA = "0x4329B2C")]
    public void SetSampleFileNameList(IEnumerable<string> list)
    {
    }

    [Token(Token = "0x601303E")]
    [Address(RVA = "0x4329CB4", Offset = "0x4329CB4", VA = "0x4329CB4")]
    public AdvViewerViewSampleAdv()
    {
    }
  }
}
