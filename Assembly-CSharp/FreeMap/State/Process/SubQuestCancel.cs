// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.SubQuestCancel
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
  [Token(Token = "0x20017F2")]
  public class SubQuestCancel : FreeMapProcess
  {
    [Token(Token = "0x4006909")]
    [FieldOffset(Offset = "0x34")]
    private int subquestID;

    [Token(Token = "0x600878A")]
    [Address(RVA = "0x43D6A48", Offset = "0x43D6A48", VA = "0x43D6A48")]
    public SubQuestCancel(FreeMapStateManager entity, int subquestID)
    {
    }

    [Token(Token = "0x600878B")]
    [Address(RVA = "0x43D7B40", Offset = "0x43D7B40", VA = "0x43D7B40", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600878C")]
    [Address(RVA = "0x43D7BE0", Offset = "0x43D7BE0", VA = "0x43D7BE0")]
    private IEnumerator CancelAPI(SubQuestData subquest) => (IEnumerator) null;

    [Token(Token = "0x600878D")]
    [Address(RVA = "0x43D7C7C", Offset = "0x43D7C7C", VA = "0x43D7C7C")]
    private void OnSucceed(APIStorySubquestCancellationResponse _, SubQuestData subquest)
    {
    }
  }
}
