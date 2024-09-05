// Decompiled with JetBrains decompiler
// Type: Story.Ending.EndingSendSequenseTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace Story.Ending
{
  [Token(Token = "0x2000613")]
  public class EndingSendSequenseTask : SequenseTaskBase
  {
    [Token(Token = "0x4001DCC")]
    [FieldOffset(Offset = "0x10")]
    private APIStoryMainquestAdv advEndAPI;
    [Token(Token = "0x4001DCD")]
    [FieldOffset(Offset = "0x18")]
    private MainQuestADVEnd apiOnResult;
    [Token(Token = "0x4001DCE")]
    [FieldOffset(Offset = "0x20")]
    private bool isEnded;

    [Token(Token = "0x6002326")]
    [Address(RVA = "0x2DA3B04", Offset = "0x2DA3B04", VA = "0x2DA3B04", Slot = "6")]
    public override bool IsEnded() => new bool();

    [Token(Token = "0x17000503")]
    private int AdvID
    {
      [Token(Token = "0x6002327"), Address(RVA = "0x2DA3B0C", Offset = "0x2DA3B0C", VA = "0x2DA3B0C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002328"), Address(RVA = "0x2DA3B14", Offset = "0x2DA3B14", VA = "0x2DA3B14")] set
      {
      }
    }

    [Token(Token = "0x6002329")]
    [Address(RVA = "0x2DA3B1C", Offset = "0x2DA3B1C", VA = "0x2DA3B1C")]
    public EndingSendSequenseTask(int advID)
    {
    }

    [Token(Token = "0x600232A")]
    [Address(RVA = "0x2DA3BE0", Offset = "0x2DA3BE0", VA = "0x2DA3BE0", Slot = "4")]
    public override void Start()
    {
    }

    [Token(Token = "0x600232B")]
    [Address(RVA = "0x2DA3C74", Offset = "0x2DA3C74", VA = "0x2DA3C74")]
    private IEnumerator Process() => (IEnumerator) null;

    [Token(Token = "0x600232C")]
    [Address(RVA = "0x2DA3D04", Offset = "0x2DA3D04", VA = "0x2DA3D04")]
    private IEnumerator CallADVEndAPI(APIStoryMainquestAdvRequest request) => (IEnumerator) null;
  }
}
