// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowKizunaListIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using Il2CppDummyDll;
using Scenes.Story.KizunaList;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017E4")]
  public class ShowKizunaListIndex : FreeMapProcess, IKizunaListBackHandler, IKizunaListEventHandler
  {
    [Token(Token = "0x40068E0")]
    [FieldOffset(Offset = "0x38")]
    private readonly IPlayerAreaOperationEvent playerOperation;
    [Token(Token = "0x40068E1")]
    [FieldOffset(Offset = "0x40")]
    private readonly KizunaListBackDestination backDestination;

    [Token(Token = "0x6008725")]
    [Address(RVA = "0x43D4B14", Offset = "0x43D4B14", VA = "0x43D4B14")]
    public ShowKizunaListIndex(
      FreeMapStateManager entity,
      KizunaListBackDestination backDestination,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008726")]
    [Address(RVA = "0x43D4B48", Offset = "0x43D4B48", VA = "0x43D4B48", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008727")]
    [Address(RVA = "0x43D4C44", Offset = "0x43D4C44", VA = "0x43D4C44", Slot = "7")]
    public void Back(KizunaListBackDestination destination)
    {
    }

    [Token(Token = "0x6008728")]
    [Address(RVA = "0x43D4D34", Offset = "0x43D4D34", VA = "0x43D4D34", Slot = "8")]
    public void Close()
    {
    }

    [Token(Token = "0x6008729")]
    [Address(RVA = "0x43D4E40", Offset = "0x43D4E40", VA = "0x43D4E40")]
    public void CloseWithAllStackedScenes()
    {
    }

    [Token(Token = "0x600872A")]
    [Address(RVA = "0x43D4F64", Offset = "0x43D4F64", VA = "0x43D4F64", Slot = "9")]
    public void OnClose()
    {
    }

    [Token(Token = "0x600872B")]
    [Address(RVA = "0x43D4FC8", Offset = "0x43D4FC8", VA = "0x43D4FC8", Slot = "10")]
    private void Scenes\u002EStory\u002EKizunaList\u002EIKizunaListEventHandler\u002EFastTravel(
      KizunaQuestInfo.KizunaQuestCharacterInfo info)
    {
    }
  }
}
