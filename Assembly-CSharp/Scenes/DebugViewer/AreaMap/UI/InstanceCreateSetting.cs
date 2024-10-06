// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.InstanceCreateSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F64")]
  internal abstract class InstanceCreateSetting
  {
    [Token(Token = "0x400CB0C")]
    [FieldOffset(Offset = "0x10")]
    protected GUIDropdown anchorDropdown;
    [Token(Token = "0x400CB0D")]
    [FieldOffset(Offset = "0x18")]
    protected GUIDropdown modelDropdown;

    [Token(Token = "0x17003EB0")]
    private bool IsShow
    {
      [Token(Token = "0x6012866"), Address(RVA = "0x212541C", Offset = "0x212541C", VA = "0x212541C")] set
      {
      }
      [Token(Token = "0x6012867"), Address(RVA = "0x2125428", Offset = "0x2125428", VA = "0x2125428")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003EB1")]
    public int Id
    {
      [Token(Token = "0x6012868"), Address(RVA = "0x2125430", Offset = "0x2125430", VA = "0x2125430")] private set
      {
      }
      [Token(Token = "0x6012869"), Address(RVA = "0x2125438", Offset = "0x2125438", VA = "0x2125438")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003EB2")]
    public bool IsDelete
    {
      [Token(Token = "0x601286A"), Address(RVA = "0x2125440", Offset = "0x2125440", VA = "0x2125440")] private set
      {
      }
      [Token(Token = "0x601286B"), Address(RVA = "0x212544C", Offset = "0x212544C", VA = "0x212544C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003EB3")]
    public InstanceType Type
    {
      [Token(Token = "0x601286C"), Address(RVA = "0x2125454", Offset = "0x2125454", VA = "0x2125454")] get
      {
        return new InstanceType();
      }
    }

    [Token(Token = "0x17003EB4")]
    public virtual string AnimationName
    {
      [Token(Token = "0x601286D"), Address(RVA = "0x212545C", Offset = "0x212545C", VA = "0x212545C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601286E")]
    [Address(RVA = "0x21254A4", Offset = "0x21254A4", VA = "0x21254A4")]
    public InstanceCreateSetting(
      InstanceType type,
      int id,
      List<string> anchors,
      List<string> models)
    {
    }

    [Token(Token = "0x601286F")]
    [Address(RVA = "0x2124568", Offset = "0x2124568", VA = "0x2124568")]
    public void ShowSetting(
      InstanceCreateSetting.RequestCreate onCreate,
      InstanceCreateSetting.SelectHierarchy onSelect)
    {
    }

    [Token(Token = "0x6012870")]
    [Address(RVA = "0x21255A4", Offset = "0x21255A4", VA = "0x21255A4", Slot = "5")]
    public virtual void ShowWindow(Rect rect)
    {
    }

    [Token(Token = "0x6012871")]
    [Address(RVA = "0x2125620", Offset = "0x2125620", VA = "0x2125620", Slot = "6")]
    protected virtual void DrawTypeSetting()
    {
    }

    [Token(Token = "0x2002F65")]
    public delegate void RequestCreate(
      int id,
      InstanceType type,
      int anchorIdx,
      int modelIdx,
      string animation);

    [Token(Token = "0x2002F66")]
    public delegate void SelectHierarchy(int id);
  }
}
