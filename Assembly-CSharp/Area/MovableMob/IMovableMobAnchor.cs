// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.IMovableMobAnchor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob
{
  [Token(Token = "0x2002823")]
  public interface IMovableMobAnchor
  {
    [Token(Token = "0x17003780")]
    Vector3 AnchorPosition { [Token(Token = "0x600FC9D")] get; }

    [Token(Token = "0x17003781")]
    bool IsGoal { [Token(Token = "0x600FC9E")] get; }

    [Token(Token = "0x17003782")]
    IMovableMobAnchor NextAnchor { [Token(Token = "0x600FC9F")] get; }

    [Token(Token = "0x17003783")]
    float NextAnchorDistance { [Token(Token = "0x600FCA0")] get; }

    [Token(Token = "0x17003784")]
    float FadeRadius { [Token(Token = "0x600FCA1")] get; }

    [Token(Token = "0x600FCA2")]
    Vector3 GetNextPosition(float ratio);

    [Token(Token = "0x600FCA3")]
    void SetNextAnchor(IMovableMobAnchor nextAnchor);
  }
}
