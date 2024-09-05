// Decompiled with JetBrains decompiler
// Type: Story.MainStoryAdvDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000561")]
  public class MainStoryAdvDirection : IAdvDirection, IDirection
  {
    [Token(Token = "0x4001BD8")]
    [FieldOffset(Offset = "0x10")]
    private int advID;

    [Token(Token = "0x6001F07")]
    [Address(RVA = "0x2A01788", Offset = "0x2A01788", VA = "0x2A01788")]
    public MainStoryAdvDirection(int advID, bool showHeader)
    {
    }

    [Token(Token = "0x6001F08")]
    [Address(RVA = "0x2A017BC", Offset = "0x2A017BC", VA = "0x2A017BC", Slot = "4")]
    public AdvDemoInfoData GetDemoInfo() => (AdvDemoInfoData) null;

    [Token(Token = "0x6001F09")]
    [Address(RVA = "0x2A01858", Offset = "0x2A01858", VA = "0x2A01858", Slot = "5")]
    public AdvStage CreateAdvStage() => (AdvStage) null;

    [Token(Token = "0x17000441")]
    public bool ShowHeader
    {
      [Token(Token = "0x6001F0A"), Address(RVA = "0x2A018D8", Offset = "0x2A018D8", VA = "0x2A018D8", Slot = "6")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001F0B"), Address(RVA = "0x2A018E0", Offset = "0x2A018E0", VA = "0x2A018E0")] private set
      {
      }
    }
  }
}
