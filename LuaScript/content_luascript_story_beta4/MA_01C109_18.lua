-- このluaスクリプトは、MA_01C109_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",290,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera002 = SetTemplate("Actor002",103,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
lookobj = create_object("kara")
set_pos(lookobj,{0,1.43,-12})
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110123)
	Actor001 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "落胆")
-- ▲直接出力

	--★★ガレス★★:逃げ場なんてないよ、リオネス
	Talk(Actor001,"CHRNAME_GARETH","speech","L","MA_01C109_180002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リオネス★★:逃げるんだ、ガレス！！<br>ノワールとディナタンが善戦している今なら──
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","MA_01C109_180003")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力

	--★★ガレス★★:みんなの食卓を誰が守るのさ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","MA_01C109_180004")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("リオネス", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リオネス★★:そのためにあたしは<br>お前を守るんだ！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","MA_01C109_180005")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.4)
wait_time(1.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:スペシャルワンプレートは<br>作るの大変なんだよ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","MA_01C109_180006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リオネス★★:ハァ！？
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","MA_01C109_180007")

-- ▼直接出力
 --PlayPartVoice("ガレス", "否定")
-- ▲直接出力

	--★★ガレス★★:明日の仕込みは済んでる<br>めちゃめちゃにされたくないよ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","MA_01C109_180008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110123)
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
