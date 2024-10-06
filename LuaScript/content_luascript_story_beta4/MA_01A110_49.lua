-- このluaスクリプトは、MA_01A110_49.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",120,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002, {1.0, 0.08, 0.5, 0.6} , 1.0)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102008)
set_pos(BgProp,{0,0,0})
Kusa = get_object("geo_bush_round") --草
set_pos(Kusa, {0.0, -3.0, 0.0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:お姉ちゃんにはね、お暇を出してあるの<br>わたしって家族思いで寛大よね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490002")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-160,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ふたりっきりだよ。行こ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490004")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102008)
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
