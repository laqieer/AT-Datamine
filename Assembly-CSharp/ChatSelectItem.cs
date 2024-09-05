// Decompiled with JetBrains decompiler
// Type: ChatSelectItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200025D")]
public class ChatSelectItem : MonoBehaviour
{
  [Token(Token = "0x4000E09")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Text chatSelectItemName;

  [Token(Token = "0x17000143")]
  public int index
  {
    [Token(Token = "0x6000EDE"), Address(RVA = "0x1C93324", Offset = "0x1C93324", VA = "0x1C93324")] get
    {
      return new int();
    }
    [Token(Token = "0x6000EDF"), Address(RVA = "0x1C9332C", Offset = "0x1C9332C", VA = "0x1C9332C")] private set
    {
    }
  }

  [Token(Token = "0x6000EE0")]
  [Address(RVA = "0x1C93334", Offset = "0x1C93334", VA = "0x1C93334")]
  public void SetData(string name, int idx)
  {
  }

  [Token(Token = "0x6000EE1")]
  [Address(RVA = "0x1C93370", Offset = "0x1C93370", VA = "0x1C93370")]
  public ChatSelectItem()
  {
  }
}
