// Decompiled with JetBrains decompiler
// Type: StaqData.IPlayerTitleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200204D")]
  public interface IPlayerTitleInfo
  {
    [Token(Token = "0x170028D6")]
    int PreTitleId { [Token(Token = "0x600C209")] get; }

    [Token(Token = "0x170028D7")]
    int PostTitleId { [Token(Token = "0x600C20A")] get; }

    [Token(Token = "0x170028D8")]
    int TitleFrameId { [Token(Token = "0x600C20B")] get; }
  }
}
