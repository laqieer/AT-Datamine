-- このluaスクリプトは、MA_01104_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",301.8,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("still001", "content_still_10301033_image", "103010330_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ノワール★★:（………いないか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1060002")


	--★★ウレリー★★:ノワールくんの考え、教えてあげる
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060004")

-- ▼直接出力
bgm_play("BGM_Area_Noon")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,142.3,0.6)
fadeout(0,0,0,1.0, 0.6)
wait_time(0.6)
Appear(Actor002)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
fadein(0.6)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
wait_time(1.1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
shake_camera(RndCamera002, 0.3, 0.33)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ウワアッ！？ウレリー！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060006")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:「出撃はまだか」
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ウレリー★★:遠征中の円卓の騎士が何名もいて<br>学園に残った兵も先のブリテン平定戦で疲弊
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060009")


	--★★ウレリー★★:ランスロット卿もそれらの対処で大忙し<br>円卓の席が埋まるのはまだ先だよ。ただ──
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:早くも新人騎士ノワールくんの<ruby=ゲシュタルト・シフト>ＧＳ</ruby>が済んだ<br>きっと出番は近いよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060011")

-- ▼直接出力
 --スチル
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
--on_cameraframe(2)
--on_screencolor(IMAGE_COLOR, 0, -50)
show_image("still001", 0.0, 0.0, 0 ,true,false) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力

	--★★ノワール★★:（…あれはＧＳと言えるのか？<br>ティルフィングとは出会ったばかりで──）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1060014")


	--★★ノワール★★:（だけどランスロットやアーサーたちが<br>「俺はＧＳを果たした」ことにしてくれている）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1060015")

-- ▼直接出力
 --スチルここまで
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
hide_image()
  
--off_cameraframe()
--off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:（ランスロット<br>俺は…なんなんだ？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_1060016")

	change_face(Actor002,"Serious")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060018")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Appl")
-- ▲直接出力
-- ▼直接出力
wait_time(1.9)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
wait_time(1.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:なんか…すごい<br>あっという間に追い抜かれたかんじ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060021")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ウレリー★★:ワタシ、そんな勇気ないよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:すごいのはウレリーだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060024")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:学級委員長もやって<br>生徒会長代理もやって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★ウレリー★★:あっははは。うっとうしいよね。実はかなり<br>ノワールくんにも絡みに行ったりして
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キミが本気だからだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060028")

	change_face(Actor002,"Surprise")

	--★★ウレリー★★:…え
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060030")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:人と関わるのに<br>一生懸命だからじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060031")

	PlayAction(Actor002,"to  Std_No")

	--★★ウレリー★★:き、気を遣わなくていいよ<br>ワタシ別に──
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060033")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:見習いたいんだよ<br>そういうところ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ウレリー★★:ノワールくんは<br>ちゃんとやれてるよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:傭兵団の団長なんてやってたけどさ<br>戦いの依頼を受けて、それをこなして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060036")


	--★★ノワール★★:団員も増えたり減ったり…<br>落ち着ける居場所もなく各地を点々とした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060037")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:依頼主や、一緒に戦った人たちが<br>味方になったり敵になったりしてたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうしてるうちに<br>人と関わるのが、すこし怖くなった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ウレリー★★:…同じかも。ワタシも
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Normal")

	--★★ノワール★★:同じ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060041")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ウレリー★★:ワタシも、ちょっぴり同じかも
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…そうは見えないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1060043")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ウレリー★★:あっはは。見習いたまえ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1060045")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("still001", "content_still_10301033_image", "103010330_StillImage")
preload_sound("BGM_Area_Noon")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
