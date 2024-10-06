// Decompiled with JetBrains decompiler
// Type: StaqData.IntroChapterSeqContentsPramData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200200C")]
  public class IntroChapterSeqContentsPramData
  {
    [Token(Token = "0x1700278F")]
    public IntroChapterSequenceContentsTypeEnum Type
    {
      [Token(Token = "0x600BEC5"), Address(RVA = "0x2002F7C", Offset = "0x2002F7C", VA = "0x2002F7C")] get
      {
        return new IntroChapterSequenceContentsTypeEnum();
      }
      [Token(Token = "0x600BEC6"), Address(RVA = "0x2002F84", Offset = "0x2002F84", VA = "0x2002F84")] private set
      {
      }
    }

    [Token(Token = "0x17002790")]
    public int ParamValue
    {
      [Token(Token = "0x600BEC7"), Address(RVA = "0x2002F8C", Offset = "0x2002F8C", VA = "0x2002F8C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BEC8"), Address(RVA = "0x2002F94", Offset = "0x2002F94", VA = "0x2002F94")] private set
      {
      }
    }

    [Token(Token = "0x600BEC9")]
    [Address(RVA = "0x2002F9C", Offset = "0x2002F9C", VA = "0x2002F9C")]
    public IntroChapterSeqContentsPramData(
      IntroChapterSequenceContentsTypeEnum contentstype,
      int typeParamValue)
    {
    }
  }
}
