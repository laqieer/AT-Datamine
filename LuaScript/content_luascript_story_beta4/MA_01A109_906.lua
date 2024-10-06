-- このluaスクリプトは、MA_01A109_906.csvから自動生成されました --
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
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:うっし、全員そろったな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_9060002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:さっそくロンディニウムに出発しようぜ<br>偽のログレス軍を追っ払わねーと
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_9060003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:よろしく頼む<br>エレイン、ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★エレイン★★:は、はいっ！<br>ががが、がんばりますっ…
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A109_9060005")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:期待にお応え出来るよう尽力いたします
	Talk(Actor005,"CHRNAME_LOVEIN","speech","L","MA_01A109_9060006")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
lookat_weight(Actor003,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:あらあら？<br>わたしにはなにも言ってくれないわけ？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_9060007")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:もちろんギネヴィアにも期待してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9060008")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:にも？<br>ギネヴィアにも？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_9060009")

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:ふ～ん、そう<br>そういう扱いなんだ～
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_9060010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:違うって！<br>キミにそこまでの心配はいらないと思ったから…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9060011")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:おーい、痴話喧嘩なら帰って来てからにしてくれ<br>他の連中、もう先に行ってんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_9060012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、ごめん、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9060013")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ギネヴィア、この話は<br>帰ってきたらあらためてで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9060014")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:気にしないで<br>ちょっと意地悪したかっただけだから♪
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_9060015")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
