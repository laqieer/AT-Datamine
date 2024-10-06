// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.GuildNameView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x200335F")]
  internal class GuildNameView : MonoBehaviour
  {
    [Token(Token = "0x400DE8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject affiliationGuild;
    [Token(Token = "0x400DE8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text guildName;
    [Token(Token = "0x400DE8C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject notAffiliationGuild;

    [Token(Token = "0x6014304")]
    [Address(RVA = "0x1E15D30", Offset = "0x1E15D30", VA = "0x1E15D30")]
    public void SetAffiliation(string name)
    {
    }

    [Token(Token = "0x6014305")]
    [Address(RVA = "0x1E15D90", Offset = "0x1E15D90", VA = "0x1E15D90")]
    public void SetNotAffiliation()
    {
    }

    [Token(Token = "0x6014306")]
    [Address(RVA = "0x1E15E1C", Offset = "0x1E15E1C", VA = "0x1E15E1C")]
    public GuildNameView()
    {
    }
  }
}
