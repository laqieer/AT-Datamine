-- このluaスクリプトは、CO_101064_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Joy")

	--★★市民（男）②★★:いやぁ、リアム様たちに来てもらえて<br>助かりました
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020002")


	--★★市民（男）②★★:親父が怪我で動けなくなってしまって<br>商品整理が全然進まなかったんです
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:お父上には普段からお世話になっています<br>そのお礼ですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020004")


	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020005")


	--★★リアム★★:ここの店主は新種のハーブの種や苗を<br>よく譲ってくださるんです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020006")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★市民（男）②★★:正直、オレは植物にはあんまり詳しくないから
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020007")


	--★★市民（男）②★★:リアム様が父の話し相手になってくださるのが<br>とても助かってます
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020008")

	open_select_window_tag(Actor001,"Normal","CO_101064_04020010","CO_101064_04020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺がもらったハーブの種も<br>ここで買ったものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:そうですね。この店で種を購入して<br>鉢に植えたもののひとつを差し上げました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020014")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★市民（男）②★★:あなたもハーブの栽培をやっているんですね<br>困ったことがあったらいつでも相談してください
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020015")

	change_face(Actor003,"Normal")

	--★★市民（男）②★★:…父が店に立ってるときにね
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020016")

	change_face(Actor001,"Smile")

	--★★ノワール★★:はははっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そこまでしてるのか<br>親切なんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:司祭として、街の人々との触れ合いを<br>大事にしたいと考えていますから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020020")

	change_face(Actor002,"Smile")

	--★★リアム★★:…もっとも、ハーブに関しては<br>趣味の延長線上であることは否めませんけどね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020022")

	goto Block1end

::Block1end::
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺も手伝いに来た以上は頑張ったつもりだけど<br>リアムさんの足手まといになっちゃったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020024")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★市民（男）②★★:重い箱を何度も運んでいただきましたし<br>とても助かりましたよ
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020025")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:うぅーん…そうかぁ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020026")

	change_face(Actor002,"Normal")

	--★★リアム★★:謙遜はたいへん結構ですが、称賛の言葉を<br>素直に受け取ることも礼儀のひとつですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020027")


	--★★リアム★★:貴方を肯定し<br>認めているわけなのですから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020028")

	change_face(Actor001,"Smile")

	--★★ノワール★★:そういうもんか<br>ちょっと照れくさいけど…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:またいつでも手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）②★★:はい<br>頼りにさせていただきます
	Talk(Actor003,"NPCNAME_0289","speech","N","CO_101064_04020032")


	--★★リアム★★:…素直ですね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020034")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺の顔になにかついてる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_04020036")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Smile")

	--★★リアム★★:いいえ、なんでもありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020037")

	change_face(Actor002,"Normal")

	--★★リアム★★:では、今日はこのあたりで<br>解散にしましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_04020038")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
