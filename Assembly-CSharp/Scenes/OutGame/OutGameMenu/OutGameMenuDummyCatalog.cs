// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuDummyCatalog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039D9")]
  public class OutGameMenuDummyCatalog : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x400FD23")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image img;
    [Token(Token = "0x400FD24")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text txt;
    [Token(Token = "0x400FD25")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400FD26")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button button001;
    [Token(Token = "0x400FD27")]
    [FieldOffset(Offset = "0x68")]
    private OutGameMenuDummyCatalog.Param belowScreenParam;

    [Token(Token = "0x6016B86")]
    [Address(RVA = "0x3F6DC88", Offset = "0x3F6DC88", VA = "0x3F6DC88", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6016B87")]
    [Address(RVA = "0x3F6DECC", Offset = "0x3F6DECC", VA = "0x3F6DECC", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016B88")]
    [Address(RVA = "0x3F6DF54", Offset = "0x3F6DF54", VA = "0x3F6DF54", Slot = "6")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016B89")]
    [Address(RVA = "0x3F6E064", Offset = "0x3F6E064", VA = "0x3F6E064", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6016B8A")]
    [Address(RVA = "0x3F6E248", Offset = "0x3F6E248", VA = "0x3F6E248")]
    private IEnumerator _Open() => (IEnumerator) null;

    [Token(Token = "0x6016B8B")]
    [Address(RVA = "0x3F6E2D8", Offset = "0x3F6E2D8", VA = "0x3F6E2D8", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6016B8C")]
    [Address(RVA = "0x3F6E340", Offset = "0x3F6E340", VA = "0x3F6E340")]
    private IEnumerator _Close() => (IEnumerator) null;

    [Token(Token = "0x6016B8D")]
    [Address(RVA = "0x3F6E3D0", Offset = "0x3F6E3D0", VA = "0x3F6E3D0")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016B8E")]
    [Address(RVA = "0x3F6E3DC", Offset = "0x3F6E3DC", VA = "0x3F6E3DC")]
    public void UpdateDummyCatalog()
    {
    }

    [Token(Token = "0x6016B8F")]
    [Address(RVA = "0x3F6E3E0", Offset = "0x3F6E3E0", VA = "0x3F6E3E0")]
    public OutGameMenuDummyCatalog()
    {
    }

    [Token(Token = "0x20039DA")]
    public class Param : ChangeBelowScreenParameter
    {
      [Token(Token = "0x400FD28")]
      [FieldOffset(Offset = "0x18")]
      public string teststring;

      [Token(Token = "0x6016B91")]
      [Address(RVA = "0x3F6DEA4", Offset = "0x3F6DEA4", VA = "0x3F6DEA4")]
      public Param(string text)
      {
      }
    }
  }
}
