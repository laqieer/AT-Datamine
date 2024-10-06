-- このluaスクリプトは、CO_101025_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_camera_nearclip(Camera002,1.5)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Appl")
change_face(Actor001,"Smile")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Tailwag")
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
lookoj=create_object("kara")
set_pos_object(lookoj,-1.6,0.5,22.6)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よしよし！<br>かわいいなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101025_0803_Dog_Barks")
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:ずいぶん人に懐いてるけど<br>誰かの飼い犬か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera009)
wait_time(3)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor001,"to Std_Loop")
change_face(Actor001,"Normal")
Hide(Actor003)
Appear(Actor002)
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0,0,0,0)
lookat_weight(Actor002,0,0,0,0)
lookoj2=create_object("kara2")
set_pos_object(lookoj2,-1.5,1,15)
keep_delay_ik_lookat_object(Actor001,lookoj2,"kara2",1.0)
setup_small_camera_start(Camera002)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:ノワール<br>ちょっといい？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアか<br>こんなところでどうしたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010006")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:犬の居場所を教えて
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？さっきの犬のことか？<br>見てたのなら、どこに行ったかわかるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力

	--★★クレア★★:いいえ<br>わたしは見てないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:あなたの服に犬の毛がついてるでしょう<br>そこから推理したの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010010")

	PlayAction(Actor001,"to LookFor")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:あ、ほんとだ<br>よく気がついたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010012")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor001,"to Show")
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:迷い犬を探す依頼を請けてるの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010013")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★クレア★★:飼い主によると特徴は<br>「人懐こくて、すぐ誰かの足にすり寄る」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そういうことか<br>さすがは名探偵
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010015")

-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:そんなことより教えて<br>犬はどこへ行ったの？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01010016")

-- ▼直接出力
setup_small_camera_start(Camera001)
set_pos(Actor002,{-2,0.128,19})
set_rot(Actor002,{0,180,0})
lookat_delay_weight(Actor001,0.6,0.03,0.7,0,0.5)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えーと、あっち…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010017")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-2,0.128,15.8},2)
setup_small_camera_start(RndCamera009)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayActionDirect(Actor001,"to Run")
turn_chara(Actor001,180,0.3)
slidemove(Actor001,{-0.48,0.128,13.8},2)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい！<br>案内するよ、待って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01010019")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ1_2")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
