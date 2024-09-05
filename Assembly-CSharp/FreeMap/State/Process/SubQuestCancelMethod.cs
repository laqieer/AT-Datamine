// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.SubQuestCancelMethod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017EF")]
  public class SubQuestCancelMethod : FreeMapMethodProcess
  {
    [Token(Token = "0x40068FF")]
    [FieldOffset(Offset = "0x20")]
    private int subquestID;

    [Token(Token = "0x600877E")]
    [Address(RVA = "0x43D7664", Offset = "0x43D7664", VA = "0x43D7664")]
    public SubQuestCancelMethod(FreeMapStateManager entity, int subquestID)
    {
    }

    [Token(Token = "0x600877F")]
    [Address(RVA = "0x43D7688", Offset = "0x43D7688", VA = "0x43D7688", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008780")]
    [Address(RVA = "0x43D7728", Offset = "0x43D7728", VA = "0x43D7728")]
    private IEnumerator CancelAPI(SubQuestData subquest) => (IEnumerator) null;

    [Token(Token = "0x6008781")]
    [Address(RVA = "0x43D77C4", Offset = "0x43D77C4", VA = "0x43D77C4")]
    private void OnSucceed(APIStorySubquestCancellationResponse _, SubQuestData subquest)
    {
    }
  }
}
