-- このluaスクリプトは、CO_101064_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そういえば、さっき聞きそびれたけど<br>リアムさんとモルドレッドは知り合いなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07030002")


	--★★リアム★★:知り合いといえば知り合いですし<br>知り合いでないといえば知り合いではありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07030004")


	--★★リアム★★:私がこの街に来てすぐのことなんですが<br>ムシにたかられましてね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030005")


	--★★リアム★★:モルドレッド卿は<br>そのムシの飼い主だったんですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030007")


	--★★リアム★★:そこから何度か街ですれ違ったことがあります<br>…その程度の関係ですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030009")

	open_select_window_tag(Actor001,"Normal","CO_101064_07030011","CO_101064_07030012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それで…<br>どっちが勝ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07030014")

	change_face(Actor002,"Normal")

	--★★リアム★★:ノワール卿もおかしなことをおっしゃいますね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030015")

	change_face(Actor002,"Smile")

	--★★リアム★★:私はムシをはらっただけです<br>そこに勝ち負けはありませんよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:あの、リアムさん…<br>実は俺、ムシの類が苦手でさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07030018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:話を聞いているだけで気持ち悪くなってきた<br>今日は帰っていいかな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07030019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★リアム★★:ああ、それは失礼しました<br>あとは私がやっておきますので
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07030020")

	goto Block1end

::Block1end::
	change_face(Actor001,"Sad")

	--★★ノワール★★:（モルドレッドにリアムさんのことを聞くのは…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_07030022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（やめておいたほうがよさそうだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_07030023")

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
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
