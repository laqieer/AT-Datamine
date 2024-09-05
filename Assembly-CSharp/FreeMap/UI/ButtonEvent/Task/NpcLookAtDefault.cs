// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.NpcLookAtDefault
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x200171E")]
  public class NpcLookAtDefault : NpcLookAtBase
  {
    [Token(Token = "0x40066FB")]
    private const float ChangeTime = 0.25f;

    [Token(Token = "0x60082D1")]
    [Address(RVA = "0x420265C", Offset = "0x420265C", VA = "0x420265C")]
    public NpcLookAtDefault(FreeMapInstanceHolder instanceHolder, InstanceID instanceID)
    {
    }

    [Token(Token = "0x60082D2")]
    [Address(RVA = "0x420268C", Offset = "0x420268C", VA = "0x420268C", Slot = "7")]
    public override void Execute()
    {
    }

    [Token(Token = "0x60082D3")]
    [Address(RVA = "0x42026A4", Offset = "0x42026A4", VA = "0x42026A4")]
    protected void StopLook()
    {
    }
  }
}
