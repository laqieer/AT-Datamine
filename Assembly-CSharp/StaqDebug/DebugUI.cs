// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F5A")]
  public class DebugUI : SingletonMonoBehaviour<DebugUI>
  {
    [Token(Token = "0x4008656")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, DebugUIView> views;

    [Token(Token = "0x600BA2E")]
    [Address(RVA = "0x2143034", Offset = "0x2143034", VA = "0x2143034")]
    public static void CreateInstance()
    {
    }

    [Token(Token = "0x600BA2F")]
    [Address(RVA = "0x21430C0", Offset = "0x21430C0", VA = "0x21430C0")]
    public DebugUIView CreateView(int viewId) => (DebugUIView) null;

    [Token(Token = "0x600BA30")]
    [Address(RVA = "0x214325C", Offset = "0x214325C", VA = "0x214325C")]
    public void RemoveView(int viewId)
    {
    }

    [Token(Token = "0x600BA31")]
    [Address(RVA = "0x21432B4", Offset = "0x21432B4", VA = "0x21432B4")]
    public void RegisterButton(string name, Action OnClickedButton, int width, int height)
    {
    }

    [Token(Token = "0x600BA32")]
    [Address(RVA = "0x21432CC", Offset = "0x21432CC", VA = "0x21432CC")]
    public void RegisterButton(
      int viewId,
      string name,
      Action OnClickedButton,
      int width,
      int height)
    {
    }

    [Token(Token = "0x600BA33")]
    [Address(RVA = "0x21434E4", Offset = "0x21434E4", VA = "0x21434E4")]
    public void Rename(string name, string rename)
    {
    }

    [Token(Token = "0x600BA34")]
    [Address(RVA = "0x214360C", Offset = "0x214360C", VA = "0x214360C")]
    public void SetPivot(int viewId, DebugUIView.PivotVirtical pivot)
    {
    }

    [Token(Token = "0x600BA35")]
    [Address(RVA = "0x2143734", Offset = "0x2143734", VA = "0x2143734")]
    public void SetVisible(int viewId, bool value)
    {
    }

    [Token(Token = "0x600BA36")]
    [Address(RVA = "0x214377C", Offset = "0x214377C", VA = "0x214377C")]
    public DebugUIView GetView(int viewId) => (DebugUIView) null;

    [Token(Token = "0x600BA37")]
    [Address(RVA = "0x2143170", Offset = "0x2143170", VA = "0x2143170")]
    public bool TryGetView(int viewId, ref DebugUIView view) => new bool();

    [Token(Token = "0x600BA38")]
    [Address(RVA = "0x21437A0", Offset = "0x21437A0", VA = "0x21437A0")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600BA39")]
    [Address(RVA = "0x2143C80", Offset = "0x2143C80", VA = "0x2143C80")]
    public DebugUI()
    {
    }
  }
}
