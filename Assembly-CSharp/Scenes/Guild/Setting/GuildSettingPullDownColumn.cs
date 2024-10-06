// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Setting.GuildSettingPullDownColumn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Setting
{
  [Token(Token = "0x2002BAE")]
  public class GuildSettingPullDownColumn : MonoBehaviour
  {
    [Token(Token = "0x400B9EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text txtTitle;
    [Token(Token = "0x400B9EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject onImg;
    [Token(Token = "0x400B9ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject offImg;
    [Token(Token = "0x400B9EE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B9EF")]
    [FieldOffset(Offset = "0x38")]
    private Action<int> onClickCallback;

    [Token(Token = "0x17003ADF")]
    public int Key
    {
      [Token(Token = "0x60110F6"), Address(RVA = "0x1C7B910", Offset = "0x1C7B910", VA = "0x1C7B910")] get
      {
        return new int();
      }
      [Token(Token = "0x60110F7"), Address(RVA = "0x1C7B918", Offset = "0x1C7B918", VA = "0x1C7B918")] private set
      {
      }
    }

    [Token(Token = "0x17003AE0")]
    public string Title
    {
      [Token(Token = "0x60110F8"), Address(RVA = "0x1C7B920", Offset = "0x1C7B920", VA = "0x1C7B920")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60110F9")]
    [Address(RVA = "0x1C7B944", Offset = "0x1C7B944", VA = "0x1C7B944")]
    public void Setup(int key, string title, Action<int> callback)
    {
    }

    [Token(Token = "0x60110FA")]
    [Address(RVA = "0x1C7B990", Offset = "0x1C7B990", VA = "0x1C7B990")]
    public void SetActivate(bool isActive)
    {
    }

    [Token(Token = "0x60110FB")]
    [Address(RVA = "0x1C7B9D8", Offset = "0x1C7B9D8", VA = "0x1C7B9D8")]
    public void OnClick()
    {
    }

    [Token(Token = "0x60110FC")]
    [Address(RVA = "0x1C7BA20", Offset = "0x1C7BA20", VA = "0x1C7BA20")]
    public GuildSettingPullDownColumn()
    {
    }
  }
}
