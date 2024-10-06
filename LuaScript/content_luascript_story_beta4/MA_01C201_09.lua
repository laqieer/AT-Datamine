-- このluaスクリプトは、MA_01C201_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("リオネス", "肯定")
-- ▲直接出力

	--★★リオネス★★:ギネヴィア捜索大作戦は<br>このメンツでいくってことだな！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C201_090002")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★リオネス★★:よーし、張り切っていくぞ！<br>ガレス、お弁当の準備はいいか！？
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C201_090003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:バッチリ～！<br>おふたりさんは？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C201_090004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookWeight = {0.9, 0.1, 0.5, 0.35}
lookat_delay_weight(Actor002, lookWeight,0.8)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん。私たちも大丈夫<br>ね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_090005")


	--★★ディナタン★★:ギネヴィアさんは、森から帰ってきた<br>私たちに「おかえり」って言ってくれた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_090006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:あのとき私、すごくホッとしたんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_090007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だから…今度は私たちが<br>ギネヴィアさんを迎えてあげようね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_090008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、行こう<br>キャメリアードへ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_090009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
