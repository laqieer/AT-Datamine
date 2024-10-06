-- このluaスクリプトは、MA_01108_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",30,CharaPos114021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_006)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
load_image("still001", "content_still_10101020_image", "101010200_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:じゃ、国王に挨拶してくるよ<br>海でも眺めながら待ってて
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_060002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera090)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0, 324.508, 0,0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera090)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
se_play("SE_ADV_MA_01B110_29_Sea_Waves")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera001)
-- ▲直接出力

	--★★ランスロット★★:いいものか？海は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_060004")

	change_face(Actor001,"Smile")

	--★★ノワール★★:昔、父さんと一緒に行った海辺で<br>釣りが苦手なあんたの姿を思い出した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_060006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-24.74,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:魚など泳いで捕まえるなり<br>剣で刺してしまえばいいんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_060008")

-- ▼直接出力
 --スチル表示
CloseTalkWindow()
fadeout(0,0,0,1.0, 1.2)
--暗転中、波のSE入れてもいい
wait_time(2.1)
-- ▲直接出力
-- ▼直接出力
show_image("still001", 0.0, 0.0, 0.3, true, false)
-- ▲直接出力
-- ▼直接出力
fadein(1.2)
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B110_29_Sea_Waves")
-- ▲直接出力

	--★★ノワール★★:あのころと同じ言い訳
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_060009")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ランスロット★★:余裕がないんだ、きっとな
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060010")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:余裕？
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_060011")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0, 40.0, 0,0.3)
-- ▲直接出力

	--★★ランスロット★★:じっと待つ余裕が
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060012")


	--★★ランスロット★★:いつもなにかに急かされている気がする<br>休む暇があるぐらいなら走りたいと
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:おかげであんたに見つけてもらえた
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_060014")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前が、俺や師匠を信じ続け<br>追いかけ続けてくれたおかげだ
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060015")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…また、昔のように戻りたいと願っている<br>それは俺のささやかな夢だ
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:戦いを終わらせるため<br>今しばらくは急ぎ足で行く
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060017")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ランスロット★★:俺が足を海辺で止めたら──<br>腰が下ろせる余裕ができたなら──
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:…きっと、師匠と共に歩める日がくる<br>務めや使命を果たし、その日々を勝ち取ったら…
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060019")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:至らぬ俺に<br>釣りでも教えてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","simple","L","MA_01108_060020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("still001", "content_still_10101020_image", "101010200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
