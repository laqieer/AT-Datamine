-- このluaスクリプトは、CO_101001_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:このあいだ、ログレスへ通じる街道のひとつで<br>暴れている盗賊を追い払ってくれただろう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020002")


	--★★アーサー★★:奴らの拠点を見つけたんだ<br>そこへ調査に行って欲しい
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それはいいけど…<br>いったいなにを調査するんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:奴らは遺物や骨董品をおもに狙う集団でな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020005")


	--★★アーサー★★:奴らが集めた品のなかに聖杯や継承者に繋がる<br>手がかりがないか調べてきて欲しい
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_08020008","CO_101001_08020009","CO_101001_08020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:伝説について<br>なにかがわかるかもしれないわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020012")

	change_face(Actor003,"Normal")

	--★★アーサー★★:保証はまるでないけどな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんにしても、わかった<br>そういうことなら行ってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:お任せください、アーサー様
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひょっとしたら<br>キミの昔の仲間についての記録もあるかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020017")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:マスター…！
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私のことなどいいのです<br>アナタの任務を優先してください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08020020")

	change_face(Actor003,"Surprise")

	--★★アーサー★★:なんの話だ？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020021")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:こっちのこと<br>それより、任務については理解したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか手がかりが見つかるっていう<br>保証があるわけじゃないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020024")

	change_face(Actor003,"Normal")

	--★★アーサー★★:それはまあ、そうなんだがな、うん
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020025")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:手がかりがないと決まったわけでもありません<br>行ってみましょう、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミがそこまで言うなら<br>行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08020027")

	goto Block1end

::Block1end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:じゃあ、頼んだぞ<br>ふたりとも
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101001_08020029")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ8_3")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
