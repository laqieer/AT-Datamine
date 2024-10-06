// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestPopupHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x200068B")]
  public class KizunaQuestPopupHandler
  {
    [Token(Token = "0x4001F6D")]
    [FieldOffset(Offset = "0x10")]
    private KizunaQuestPopup popup;
    [Token(Token = "0x4001F6E")]
    [FieldOffset(Offset = "0x18")]
    private KizunaQuestLoader loader;
    [Token(Token = "0x4001F6F")]
    [FieldOffset(Offset = "0x20")]
    private KizunaQuestAnimation animation;
    [Token(Token = "0x4001F70")]
    [FieldOffset(Offset = "0x28")]
    public Action OnClickFastTravelAction;
    [Token(Token = "0x4001F71")]
    [FieldOffset(Offset = "0x30")]
    public Action OnCloseAction;

    [Token(Token = "0x1700057B")]
    public bool IsOpening
    {
      [Token(Token = "0x6002558"), Address(RVA = "0x2F38470", Offset = "0x2F38470", VA = "0x2F38470")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002559"), Address(RVA = "0x2F38478", Offset = "0x2F38478", VA = "0x2F38478")] private set
      {
      }
    }

    [Token(Token = "0x600255A")]
    [Address(RVA = "0x2F38484", Offset = "0x2F38484", VA = "0x2F38484")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x600255B")]
    [Address(RVA = "0x2F38518", Offset = "0x2F38518", VA = "0x2F38518")]
    public KizunaQuestPopupHandler()
    {
    }

    [Token(Token = "0x600255C")]
    [Address(RVA = "0x2F385AC", Offset = "0x2F385AC", VA = "0x2F385AC")]
    public IEnumerator Show(IKizunaQuestPopupParam uiParam) => (IEnumerator) null;

    [Token(Token = "0x600255D")]
    [Address(RVA = "0x2F38648", Offset = "0x2F38648", VA = "0x2F38648")]
    public void Clear()
    {
    }
  }
}
