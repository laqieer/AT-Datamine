// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaSettingsPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using staq.SaveData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003134")]
  public class ArenaSettingsPopup : PopupBase
  {
    [Token(Token = "0x400D181")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<ArenaSettingsListItem> items;

    [Token(Token = "0x1700404B")]
    private ArenaSaveData Settings
    {
      [Token(Token = "0x601332D"), Address(RVA = "0x45E69AC", Offset = "0x45E69AC", VA = "0x45E69AC")] get
      {
        return (ArenaSaveData) null;
      }
    }

    [Token(Token = "0x601332E")]
    [Address(RVA = "0x45E6A24", Offset = "0x45E6A24", VA = "0x45E6A24", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x601332F")]
    [Address(RVA = "0x45E6C20", Offset = "0x45E6C20", VA = "0x45E6C20", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6013330")]
    [Address(RVA = "0x45E6A40", Offset = "0x45E6A40", VA = "0x45E6A40")]
    private void Setup()
    {
    }

    [Token(Token = "0x6013331")]
    [Address(RVA = "0x45E6C3C", Offset = "0x45E6C3C", VA = "0x45E6C3C")]
    private void Save()
    {
    }

    [Token(Token = "0x6013332")]
    [Address(RVA = "0x45E6E44", Offset = "0x45E6E44", VA = "0x45E6E44")]
    public ArenaSettingsPopup()
    {
    }
  }
}
