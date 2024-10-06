-- このluaスクリプトは、MA_01A109_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
mob1 = setup_prop_object(10130024)
-- ▲直接出力
-- ▼直接出力
mob2 = setup_prop_object(10130025)
-- ▲直接出力
-- ▼直接出力
mob3 = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
mob4 = setup_prop_object(10130013)
-- ▲直接出力
-- ▼直接出力
mob5 = setup_prop_object(10130015)
-- ▲直接出力
-- ▼直接出力
set_pos(mob1,{2.29, 0, -9.42})
set_rot(mob1,{0,320,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob2,{-4.64, 0, -7.27})
set_rot(mob2,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob3,{-7.13, 0, -3.56})
set_rot(mob3,{0,291.3538,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob4,{-7.23, 0, 1.48})
set_rot(mob4,{0,202.7133,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob5,{9.01, 0, -3.18})
set_rot(mob5,{0,254.8817,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.46, 0, -5.4})
set_rot(Actor003,{0,275.3804,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-2.11, 0, -4.75})
set_rot(Actor004,{0,106.2227,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{3.25, 0, 5.28,   284.2421}	)
set_rot(Actor005,{0,284.2421,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{3.69, 0, 6.76,   230.8243})
set_rot(Actor006,{0,230.8243,0})
-- ▲直接出力
-- ▼直接出力
CAMERAEX001 = set_camera({-0.27, 1.61, -1.94,   7.86471, 185.5585, 0,   37})
-- ▲直接出力
-- ▼直接出力
CAMERAEX002 = set_camera({0.52, 1.86, 4.7,   10.95969, 256.8026, 359.0699,   37})
-- ▲直接出力
-- ▼直接出力
keep_turn_lookat(Actor002,Actor001,100)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000013)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:さびしかった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ごめん。人が多くて──
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:となり、空いてるけど？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350004")

	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:聞いた？花火が上がるんだって<br>楽しみじゃない？楽しみってのも変だけど
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350006")


	--★★ギネヴィア★★:わたしね、きらきらしてるの好きなんだあ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:だから探したの<br>あなたとの特等席
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Camera002 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED + FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…悲しいはずなのに<br>みんな笑顔で送り出してあげてるんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350010")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:強いんだねえ。みんな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350011")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:ギネヴィアだって
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:お別れくらい笑顔でしたいもん<br>パパにね、キャメリアードの仇は任せとけって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:わたしがノワールのキラーズになったからには<br>もー好きにはさせないぞって念を送ったの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350014")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…パパも、キャメリアードの人たちにも<br>安心して眠って欲しくて
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:だから、ちゃあんと笑顔
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350016")

	change_face(Actor002,"Normal")

	--★★ノワール★★:…ギネヴィアとのGS
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350017")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:誇らしい？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:誇らしく思ってくれるよな<br>とうさんもきっと
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350020")


	--★★ギネヴィア★★:──誰か
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350023")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:誰か、いなくなっちゃったの？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350024")

	change_face(Actor002,"Normal")

	--★★ノワール★★:…わかるのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:わかんないけど…わかる<br>わたし、ずっとあなたを見てたから
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350026")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:わたし、あなたのお話が聞きたいな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:いなくなった人のこと<br>わたしも覚えてちゃだめかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350029")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:で、時々あなたが言うの「あれってなんだっけ」<br>そしたらわたしが言うの「これこれこうだよ」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ひとりで持ち切れないものは<br>ふたりで抱えようよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:わたし、あなたと同じ思い出が欲しいよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350032")


	--★★ギネヴィア★★:泣き虫め
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:君が言うか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_350035")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:わたしはいなくなんないからね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_350037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130024)
setup_prop_object_preload(10130025)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130015)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000013)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
