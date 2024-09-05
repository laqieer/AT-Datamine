// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AutoMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.UI;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017B5")]
  public class AutoMove : FreeMapPlayerProcess
  {
    [Token(Token = "0x40068A1")]
    [FieldOffset(Offset = "0x20")]
    protected FreeMapPlayerInstance playerInstance;
    [Token(Token = "0x40068A2")]
    [FieldOffset(Offset = "0x28")]
    protected FreeMapUITransformHolder transformHolder;

    [Token(Token = "0x6008679")]
    [Address(RVA = "0x43CE998", Offset = "0x43CE998", VA = "0x43CE998")]
    public AutoMove(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600867A")]
    [Address(RVA = "0x43CE9A0", Offset = "0x43CE9A0", VA = "0x43CE9A0")]
    public AutoMove(FreeMapStateManager entity, FreeMapUITransformHolder transformHolder)
    {
    }

    [Token(Token = "0x600867B")]
    [Address(RVA = "0x43CEADC", Offset = "0x43CEADC", VA = "0x43CEADC", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600867C")]
    [Address(RVA = "0x43CEB1C", Offset = "0x43CEB1C", VA = "0x43CEB1C")]
    protected GameObject SetAutoMove(FreeMapUITransformHolder transformHolder) => (GameObject) null;

    [Token(Token = "0x600867D")]
    [Address(RVA = "0x43CEB8C", Offset = "0x43CEB8C", VA = "0x43CEB8C", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x600867E")]
    [Address(RVA = "0x43CEC48", Offset = "0x43CEC48", VA = "0x43CEC48")]
    private void CancelMove()
    {
    }

    [Token(Token = "0x600867F")]
    [Address(RVA = "0x43CEC9C", Offset = "0x43CEC9C", VA = "0x43CEC9C", Slot = "8")]
    protected virtual void OnCancelMove()
    {
    }

    [Token(Token = "0x6008680")]
    [Address(RVA = "0x43CECA0", Offset = "0x43CECA0", VA = "0x43CECA0", Slot = "9")]
    protected virtual void OnAutoMoveFinish()
    {
    }
  }
}
