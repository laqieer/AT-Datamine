-- このluaスクリプトは、CO_101026_0904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_005)
	Camera003 = SetTemplate("Actor003",195,CharaPos114101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_007)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
prop001 = setup_prop_object(10130004)
set_pos(prop001 , {0.27,0,7.76})
set_rot(prop001,{0, 26.863, 0})
-- ▲直接出力
-- ▼直接出力
prop002 = setup_prop_object(10130004)
set_pos(prop002 , {-0.67,0,10.25})
set_rot(prop002,{0, 128.544, 0})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
off_active(prop001)
-- ▲直接出力
-- ▼直接出力
off_active(prop002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","002","101027002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
on_active(prop001)
on_active(prop002)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これまでとは景色が違う場所に出た<br>ここはいったい…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09040002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:バルバロイ！？<br>それにあれは…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040004")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:義姉さん！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040006")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,102,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ディンドラン★★:ああ、パー坊…<br>心配してきてくれたの？義姉さん嬉しいわ…
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040008")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:冗談を言ってる場合じゃないだろう！<br>ケガは？大丈夫なのか！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:こんなのケガのうちに入らないわ<br>義姉さん、強いんだから
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:良かった…本当に良かった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:でも、なんだって<br>ひとりでこの森に入るなんて無茶をしたのさ！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:妖精の森は<br>人々の失われた記憶が集まる場所と聞くわ
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040013")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true)
slidemove(Actor001,{0.28,0,9.677}, 0)
-- ▲直接出力

	--★★ディンドラン★★:ひょっとしたらジャンの記憶を<br>戻してあげられるんじゃないかと思ったの
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040014")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:だからって義姉さんに万が一のことがあったら<br>なんの意味もないじゃないか！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040015")

-- ▼直接出力
wait_time(0.2)
setup_small_camera_start(Camera002)
 turn_chara(Actor001,-243,0)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ボクはこれ以上<br>誰かがキズつくのを見たくない…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040016")

-- ▼直接出力
wait_time(0.2)
CloseTalkWindow()
Camera003 = setup_small_camera_resetting(Actor003,CharaPos003,CameraPos003)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,32.706,0)
slidemove(Actor003,{1.858,0,8.435}, 1.8)
wait_time(1.3)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Bow")
wait_time(0.88)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to ReadLetter")
wait_time(0.3)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディンドラン★★:パー坊、ごめんなさい…
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040018")

-- ▼直接出力
wait_time(1.5)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,15.25,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor003,15.25,2.0)
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:それよりも周りを見て<br>ここは妖精の隠れ里の近くかもしれません
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040020")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:進んでみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09040022")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.1)
PlayActionDirect(Actor003,"to Wlk")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:道の先に見えるのはなんだ？<br>あれが妖精の隠れ里だろうか？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09040024")

-- ▼直接出力
PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディンドラン★★:いえ、随分明るいわ<br>森の外に出るようね
	Talk(Actor003,"CHRNAME_DINDRANE2","speech","L","CO_101026_09040025")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…そ、そんな…ここは…この場所は…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09040026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ9_5")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130004)
setup_prop_object_preload(10130004)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","002","101027002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
