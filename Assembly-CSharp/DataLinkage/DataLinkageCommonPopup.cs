// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageCommonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F6A")]
  internal class DataLinkageCommonPopup
  {
    [Token(Token = "0x400868A")]
    [FieldOffset(Offset = "0x10")]
    private PopupHandle popupHandle;

    [Token(Token = "0x170026B1")]
    public bool IsDestroied
    {
      [Token(Token = "0x600BA7A"), Address(RVA = "0x1E460B4", Offset = "0x1E460B4", VA = "0x1E460B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BA7B")]
    [Address(RVA = "0x1E460D0", Offset = "0x1E460D0", VA = "0x1E460D0")]
    public void OpenCompleteAddDevice()
    {
    }

    [Token(Token = "0x600BA7C")]
    [Address(RVA = "0x1E463C8", Offset = "0x1E463C8", VA = "0x1E463C8")]
    public void OpenCompleteConnect()
    {
    }

    [Token(Token = "0x600BA7D")]
    [Address(RVA = "0x1E466C0", Offset = "0x1E466C0", VA = "0x1E466C0")]
    public void OpenCompleteDisconnect(string snsName)
    {
    }

    [Token(Token = "0x600BA7E")]
    [Address(RVA = "0x1E469D0", Offset = "0x1E469D0", VA = "0x1E469D0")]
    public void OpenError(string errorCode, string snsName = null)
    {
    }

    [Token(Token = "0x600BA7F")]
    [Address(RVA = "0x1E46F94", Offset = "0x1E46F94", VA = "0x1E46F94")]
    public DataLinkageCommonPopup()
    {
    }
  }
}
