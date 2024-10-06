// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.PopupHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CFE")]
  public class PopupHandle
  {
    [Token(Token = "0x4003A0C")]
    [FieldOffset(Offset = "0x10")]
    private PopupBase popupInstance;

    [Token(Token = "0x17000AF1")]
    public PopupBase Instance
    {
      [Token(Token = "0x6004AB4"), Address(RVA = "0x31407A0", Offset = "0x31407A0", VA = "0x31407A0")] get
      {
        return (PopupBase) null;
      }
    }

    [Token(Token = "0x17000AF2")]
    public bool IsDestroyed
    {
      [Token(Token = "0x6004AB5"), Address(RVA = "0x31407A8", Offset = "0x31407A8", VA = "0x31407A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004AB6")]
    [Address(RVA = "0x3140808", Offset = "0x3140808", VA = "0x3140808")]
    public PopupHandle(PopupBase popup)
    {
    }

    [Token(Token = "0x6004AB7")]
    [Address(RVA = "0x3140830", Offset = "0x3140830", VA = "0x3140830")]
    public void DisableBackkey()
    {
    }
  }
}
