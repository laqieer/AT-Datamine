// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2EditorSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E57")]
  public class Adv2EditorSettings : ScriptableObject
  {
    [Token(Token = "0x40111AC")]
    [FieldOffset(Offset = "0x18")]
    public List<Adv2EditorSettings.PrefabShortcutPack> PrefabLists;
    [Token(Token = "0x40111AD")]
    [FieldOffset(Offset = "0x20")]
    public List<UnityEngine.Object> MapList;
    [Token(Token = "0x40111AE")]
    [FieldOffset(Offset = "0x28")]
    public List<string> KindList;
    [Token(Token = "0x40111AF")]
    [FieldOffset(Offset = "0x30")]
    public string Path_SettingsRoot;
    [Token(Token = "0x40111B0")]
    [FieldOffset(Offset = "0x38")]
    public string Path_SettingsRootFree;

    [Token(Token = "0x60191AC")]
    [Address(RVA = "0x2CF09D4", Offset = "0x2CF09D4", VA = "0x2CF09D4")]
    public Adv2EditorSettings()
    {
    }

    [Token(Token = "0x2003E58")]
    [Serializable]
    public class PrefabShortcut
    {
      [Token(Token = "0x40111B1")]
      [FieldOffset(Offset = "0x10")]
      public string Tag;
      [Token(Token = "0x40111B2")]
      [FieldOffset(Offset = "0x18")]
      public UnityEngine.Object Prefab;

      [Token(Token = "0x60191AD")]
      [Address(RVA = "0x2CF0B14", Offset = "0x2CF0B14", VA = "0x2CF0B14")]
      public PrefabShortcut()
      {
      }
    }

    [Token(Token = "0x2003E59")]
    [Serializable]
    public class PrefabShortcutPack
    {
      [Token(Token = "0x40111B3")]
      [FieldOffset(Offset = "0x10")]
      public string Tag;
      [Token(Token = "0x40111B4")]
      [FieldOffset(Offset = "0x18")]
      public List<Adv2EditorSettings.PrefabShortcut> ShortcutList;

      [Token(Token = "0x60191AE")]
      [Address(RVA = "0x2CF0B6C", Offset = "0x2CF0B6C", VA = "0x2CF0B6C")]
      public PrefabShortcutPack()
      {
      }
    }
  }
}
