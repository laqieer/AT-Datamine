-- このluaスクリプトは、MA_01107_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",-50,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ほんとユーウツね<br>あいつの手のひらの上だと思うと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_170002")


	--★★トリスタン★★:ルーシャス皇太子殿下は<br>無事不登校を脱して学園へ戻って来るそうだよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01107_170004")


	--★★ギネマウア★★:ゲームに飽きて<br>出て来られたということでしょうか
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170005")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Sad")

	--★★トリスタン★★:まだ３つ目のゲームが残ってる<br>いやあ楽しみだね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01107_170006")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:…この先が<br>キャメリアード鉱山の入り口です
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170007")


	--★★ギネマウア★★:かつては宝石だけでなく<br>さまざまな鉱石も産出されていたのですが
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170008")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:宝石の鉱床が枯渇してからは<br>鉱山は閉鎖され
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:足を踏み入れる者はいません<br>バルバロイが巣くっているという噂もあります
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01107_170012","MA_01107_170013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:少しでも<br>宝石が残っていてくれるといいけれど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_170015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:最奥になら<br>残っている可能性は０ではありませんが
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170016")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:命の保証はできかねます
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:こ、怖いこと言わないでよ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_170018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでも<br>行ってみるしかないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_170019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:気を付けて進もう<br>先頭は俺に任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_170021")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Appl")
turn_chara(Actor002,-40,0.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:頼もしい～！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_170022")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,-83,0.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:こちら古いものですが<br>内部の地図です
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_170023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_170024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:いずれはキャメリアードの安全を<br>確保しないと、と思っていたところではあるし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_170026")

-- ▼直接出力
setup_small_camera_start(Camera002)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:実家の掃除のついでよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_170027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
