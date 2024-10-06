-- このluaスクリプトは、CO_101025_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110161_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_004)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
Prop_01 = get_object("geo_desk_item_09")
set_pos(Prop_01, {0,0,1.6})
Prop_02 = get_object("geo_chair_14")
set_pos(Prop_02, {1.05,0,3.13})
set_rot(Prop_02,{0,0,0})
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:犯人の足取りを追うための<br>手がかりが不足しているわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★クレア★★:以前ノワールに描いてもらった似顔絵を使って<br>あらためて犯人について調べてみましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07020003")


	--★★クレア★★:知り合いなどが見つかって素性が知れれば<br>犯人の次の潜伏先に検討が付けられるかも
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07020004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほどな…<br>ログレスで聞き込みをしてみようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07020005")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ7_2_1")
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
