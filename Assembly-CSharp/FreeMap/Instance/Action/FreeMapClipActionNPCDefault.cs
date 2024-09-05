// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapClipActionNPCDefault
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x200190F")]
  public class FreeMapClipActionNPCDefault : FreeMapClipActionBase
  {
    [Token(Token = "0x4006C45")]
    [FieldOffset(Offset = "0x18")]
    private List<AnimationClipParam> clipFileList;

    [Token(Token = "0x170016D7")]
    protected override List<AnimationClipParam> ClipFiles
    {
      [Token(Token = "0x6008E7F"), Address(RVA = "0x4B02598", Offset = "0x4B02598", VA = "0x4B02598", Slot = "9")] get
      {
        return (List<AnimationClipParam>) null;
      }
    }

    [Token(Token = "0x6008E80")]
    [Address(RVA = "0x4B025A0", Offset = "0x4B025A0", VA = "0x4B025A0")]
    public void AddClip(string tag)
    {
    }

    [Token(Token = "0x6008E81")]
    [Address(RVA = "0x4B02664", Offset = "0x4B02664", VA = "0x4B02664")]
    public FreeMapClipActionNPCDefault()
    {
    }
  }
}
