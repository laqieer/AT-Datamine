-- このluaスクリプトは、MA_01A109_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_002)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01A109_14")
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
tegami_offset = {0,0,0,0,0,0}
off_active(tegami)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Snuggle_TL")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Snuggle")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★エレイン★★:美しい<br>ってなんだと思いますか？
	Talk(Actor002,"CHRNAME_ELAINE","simple","N","MA_01A109_140002")

-- ▼直接出力
bgm_play("BGM_ADV_Snuggle_TL")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
movie_set_active(true)
movie_play()
hide_image(0)
movie_wait_playing()
movie_stop()
on_camera(RndCamera001)
setup_small_camera_start()
	--ムービー後待機
	wait_time(MOVIE_AFTER)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A109_140008","MA_01A109_140009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Snuggle")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…大丈夫？<br>どうして泣いて…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★エレイン★★:ごめんなさい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140012")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:べ、別に責めているわけじゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Snuggle")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:手紙？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:すみません…筆は<br>筆だけは早いほうなので
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうして目の前で…手紙を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140018")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
setup_small_camera_end(Camera001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
wait_time(0.5)
-- ▲直接出力

	--★★テロップ★★:「ローマから来ました」
	Talk(Actor004,"telop","narration","N","MA_01A109_140020")

-- ▼直接出力
SkipOffsetCamera(Camera001)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
off_parent(tegami)
off_active(tegami)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…君、は…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140022")

	change_face(Actor002,"Sad")

	--★★エレイン★★:亡くなった、ローマの皆さまに<br>国葬で、お花を添えます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140023")

	PlayAction(Actor002,"to  Std_No")

	--★★エレイン★★:敵に花など<br>おかしいですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140025")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
character_in_move_walk_offset(Actor003,CharaPos002,-2.5,0,-0.25,2.0)
-- ▲直接出力
	PlayAction(Actor003,"to Bow")

	--★★ラヴェイン★★:申し訳ありません<br>変わった妹で
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A109_140027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェイン…<br>貴方の妹さんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140028")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラヴェイン★★:ここで出会ったのも何かの縁<br>不躾なお願いを許してください
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A109_140029")


	--★★ラヴェイン★★:ロンディニウム奪還の折には<br>我ら兄妹の同行をお許し願えませんか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A109_140030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:お兄ちゃん…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140031")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:貴方と…、彼女も？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_140032")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★エレイン★★:………どうして、そういうことを言うの<br>お兄ちゃん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:エレインは有望ですよ<br>私よりもずっと
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A109_140034")


	--★★エレイン★★:わ、私は………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:学園が、嫌いです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_140037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
movie_load_preload("MA_01A109_14")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
preload_sound("BGM_ADV_Snuggle_TL")
preload_sound("BGM_ADV_Snuggle")
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
